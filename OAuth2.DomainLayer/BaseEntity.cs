using System.ComponentModel.DataAnnotations;

namespace OAuth2.DomainLayer
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
