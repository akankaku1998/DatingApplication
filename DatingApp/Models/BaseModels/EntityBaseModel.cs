using System.ComponentModel.DataAnnotations;

namespace DatingApp.Models.BaseModels
{
    public class EntityBaseModel
    {
        public int Id { get; set; }
        public DateTimeOffset Timestamp { get; set; } = DateTimeOffset.Now;
        public DateTimeOffset UpdatedTimestamp { get; set; }
        public DateTimeOffset DeleteTimestamp { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}