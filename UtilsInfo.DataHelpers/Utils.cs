using System.Globalization;

namespace UtilsInfo.DataHelpers
{
    public class Utils
    {

        public static DateTime? ConvertToDateTime(string dateString)
        {
            try
            {
                return string.IsNullOrEmpty(dateString) ? new DateTime?() : new DateTime?(DateTime.Parse(dateString, (IFormatProvider)new CultureInfo("en-GB")));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DateTimeToString(DateTime? dateValue, int TimeType)
        {
            try
            {
                string empty = string.Empty;
                string str;
                switch (TimeType)
                {
                    case 1:
                        str = " HH:mm:ss";
                        break;
                    case 2:
                        str = " HH:mm";
                        break;
                    default:
                        str = string.Empty;
                        break;
                }
                return !dateValue.HasValue ? "" : dateValue.Value.ToString(string.Format("dd/MM/yyyy{0}", (object)str), (IFormatProvider)new CultureInfo("en-GB"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DateTimeToString(DateTime? dateValue, bool isTime = false)
        {
            try
            {
                return !dateValue.HasValue ? "" : dateValue.Value.ToString(string.Format("dd/MM/yyyy{0}", isTime ? (object)" HH:mm:ss" : (object)""), (IFormatProvider)new CultureInfo("en-GB"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DateTimeToTimeString(DateTime? dateValue)
        {
            try
            {
                return !dateValue.HasValue ? "" : dateValue.Value.ToString("HH:mm:ss", (IFormatProvider)new CultureInfo("en-GB"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DateTime? ConvertToDateTimeTHToEN(string dateString)
        {
            try
            {
                if (!(dateString != ""))
                    return new DateTime?();
                string[] strArray1 = dateString.Split(' ');
                string[] strArray2 = strArray1[0].Split('/');
                string s = strArray2[0] + "/" + strArray2[1] + "/" + Convert.ToString(Convert.ToInt32(strArray2[2]) - 543) + (strArray1.Length > 1 ? " " + strArray1[1] : "");
                return string.IsNullOrEmpty(s) ? new DateTime?() : new DateTime?(DateTime.Parse(s, (IFormatProvider)new CultureInfo("en-GB")));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DateTimeToStringTH(DateTime? dateValue, bool isTime = false)
        {
            try
            {
                return !dateValue.HasValue ? "" : dateValue.Value.ToString(string.Format("dd/MM/yyyy{0}", isTime ? (object)" HH:mm:ss" : (object)""), (IFormatProvider)new CultureInfo("th-TH"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DateTimeToTimeStringTH(DateTime? dateValue)
        {
            try
            {
                return !dateValue.HasValue ? "" : dateValue.Value.ToString("HH:mm:ss", (IFormatProvider)new CultureInfo("th-TH"));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
