using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obligated inform the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obligated inform the plate")]
        public string Plate { get; set; }

        [Required(ErrorMessage = "Obligated inform the year of manufacture")]
        public int ManufactureYear { get; set; }

        [Required(ErrorMessage = "Obligated inform the year of model")]
        public int ModelYear { get; set; }
    }
}
