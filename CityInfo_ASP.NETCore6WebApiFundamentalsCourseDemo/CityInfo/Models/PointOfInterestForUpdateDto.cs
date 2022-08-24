using System.ComponentModel.DataAnnotations;

namespace CityInfo.Models
{
    public class PointOfInterestForUpdateDto
    {
        [Required(ErrorMessage = "Name is required when creating a POI.")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
