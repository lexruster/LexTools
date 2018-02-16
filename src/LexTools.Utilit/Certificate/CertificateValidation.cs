using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace LexTools.Utilit.Certificate
{
    public class CertificateValidation : ICertificateValidation
    {
        private IEnumerable<string> _trustedUrl;
        private bool _oldExpect100Continue;

        public void SetupCertificatePolicy(IEnumerable<string> trustedUrl)
        {
            _trustedUrl = trustedUrl.Select(x => x.ToLower());

            ServicePointManager.ServerCertificateValidationCallback += OnServerCertificateValidationCallback;
            _oldExpect100Continue = ServicePointManager.Expect100Continue;
            ServicePointManager.Expect100Continue = true;
        }

        private bool OnServerCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain,
                                                           SslPolicyErrors sslPolicyErrors)
        {
            // If the certificate is a valid, signed certificate, return true.
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }

            var request = sender as HttpWebRequest;
            if (CertificateIsAllowed(sslPolicyErrors, request))
            {
                return true;
            }

            return false;
        }

        private bool CertificateIsAllowed(SslPolicyErrors sslPolicyErrors, HttpWebRequest request)
        {
            return request != null && IsTrustedUri(request.RequestUri.ToString().ToLower()) &&
                   IsAllowedSslPolicyError(sslPolicyErrors);
        }

        private static bool IsAllowedSslPolicyError(SslPolicyErrors sslPolicyErrors)
        {
            //only for not available certificate throw error 
            return !sslPolicyErrors.HasFlag(SslPolicyErrors.RemoteCertificateNotAvailable);
        }

        private bool IsTrustedUri(string uri)
        {
            return _trustedUrl.Any(uri.Contains);
        }

        public void Dispose()
        {
            // ReSharper disable DelegateSubtraction
            ServicePointManager.ServerCertificateValidationCallback -= OnServerCertificateValidationCallback;
            // ReSharper restore DelegateSubtraction

            ServicePointManager.Expect100Continue = _oldExpect100Continue;
        }
    }
}
