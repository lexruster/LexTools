using System;
using System.Collections.Generic;

namespace LexTools.Utilit.Certificate
{
    public interface ICertificateValidation : IDisposable
    {
        void SetupCertificatePolicy(IEnumerable<string> trustedUrl);
    }
}