using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities
{
    public class ProjectPic {
      
        
        public int Id { get; set; }
        [Required]
        public Byte Type { get; set; }
        public string Date{ get; set; }
     
        public byte[] Pic { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
