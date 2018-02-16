namespace LexTools.Converter.Phone
{
    public interface IPhoneFormatter
    {
        /// <summary>
        /// Convert to format like 1-818-111-1111
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        string PhoneToFullForm(string phone);

        string GetOnlyDigits(string phone);

        string PhoneToDigits(string phone);

        string GetPhonePart(string phone);
    }
}