using System.ComponentModel.DataAnnotations;

namespace LocalGardenCommunity.Models
{
    public class Vegetables
    {
       [Key]
        public int Id { get; set; }
        public string VegetableName { get; set; }
        public string Season { get; set; }
        public string GermationPeriod { get; set; }
        public string GrowZone { get; set; }


    }
}
