using System.ComponentModel.DataAnnotations;
namespace AutoLotDAL_Core2.Models
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
