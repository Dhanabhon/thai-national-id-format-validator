using System.Text.RegularExpressions;

namespace thai_national_id_format_validator
{
    public class ThaiNationalIdFormat
    {
        public static bool IsValid(string id)
        {
            if (!Regex.IsMatch(id, @"^[0-9]{13}$"))
                return false;

            int sum = 0;
            char[] c = id.ToCharArray();
            for (int i = 0; i < 12; i++)
            {
                sum += int.Parse(c[i].ToString()) * (13 - i);
            }

            int checkSum = (11 - sum % 11) % 10;
            if (checkSum == int.Parse(c[12].ToString()))
                return true;
            else
                return false;
        }

        public static string RandomThaiNationalID()
        {
            string strNumbers = string.Empty;

            Random random = new();

            for (int i = 0; i < 13; i++)
            {
                strNumbers = string.Concat(strNumbers, random.Next(10).ToString());
            }

            return strNumbers;
        }

        public static string GenerateThaiNationalID()
        {
            string strNumbers;
            while (true)
            {
                strNumbers = RandomThaiNationalID();

                if (IsValid(strNumbers))
                    break;
            }

            return strNumbers;
        }
    } // class
} // namespace