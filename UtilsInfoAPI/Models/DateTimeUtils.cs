using UtilsInfo.DataHelpers;

namespace UtilsInfoAPI.Models
{
    public class DateTimeUtils
    {
        public DateTime? CreateDate { get; set; }
        public string CreateDateString
        {
            get => Utils.DateTimeToString(this.CreateDate);
            set => this.CreateDate = Utils.ConvertToDateTime(value);
        }

        public string CreateDateStringTH
        {
            get => Utils.DateTimeToStringTH(this.CreateDate);
            set => this.CreateDate = Utils.ConvertToDateTimeTHToEN(value);
        }

        public string CreateDateTimeString
        {
            get => Utils.DateTimeToString(this.CreateDate, true);
            set => this.CreateDate = Utils.ConvertToDateTime(value);
        }

        public string CreateDateTimeStringTH
        {
            get => Utils.DateTimeToStringTH(this.CreateDate, true);
            set => this.CreateDate = Utils.ConvertToDateTimeTHToEN(value);
        }
    }
}
