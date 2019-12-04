using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities
{
    public class Offer {
      
        
        public int Id { get; set; }
        [Required]
        [StringLength(300, MinimumLength=10)]
        public string subject { get; set; }
        [StringLength(300, MinimumLength=0)]
        public string source { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string startDate { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string endDate { get; set; }
        public string fileName { get; set; }
        public byte[] file { get; set; }
    }
}
