using System.ComponentModel.DataAnnotations;

namespace Samples.ReturnTypes.Models
{
    public class MyModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
