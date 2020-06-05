using System.ComponentModel.DataAnnotations;

namespace AirPlaneFactoryDatabaseImplement.Models
{
    public class ProductComponent
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ComponentId { get; set; }
        [Required] public int Count { get; set; }
        public virtual Component Component { get; set; }
        public virtual Product Products { get; set; }
    }
}