using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materials.Core.DTOs
{
    public class CreateMaterialDTO
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public IEnumerable<string> Tags { get; set; } = new List<string>();

    }
}
