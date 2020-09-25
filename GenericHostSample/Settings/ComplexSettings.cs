using System.ComponentModel.DataAnnotations;

namespace GenericHostSample.Settings
{
    public class ComplexSettings
    {
        public string First { get; set; }
        public string Second { get; set; }
        public int Third { get; set; }
        [Required]
        public string NotExistProperty { get; set; }
    }
}