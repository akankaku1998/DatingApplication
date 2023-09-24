using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models.BaseModels
{
    public class TimestampModel
    {
        public DateTimeOffset Timestamp { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}