using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{

    public class Hotel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = null!;
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [StringLength(50)]
        public string City { get; set; } = null!;


    }
}