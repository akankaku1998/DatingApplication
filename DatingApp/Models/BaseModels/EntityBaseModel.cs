using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models.BaseModels
{
    public class EntityBaseModel
    {
        public int Id { get; set; }
        public DateTimeOffset Timestamp { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}