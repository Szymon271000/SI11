using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materials.Core.DTOs
{
    public class ReadMaterialDTO
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateOfCreation { get; set; } = DateTime.Now;
        public IEnumerable<string> Tags { get; set; } = new List<string>();
    }
}
