using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Story
    {
        public int StoryId { get; set; }
        public string Title { get; set; }
        [Required]
        public Game Game { get; set; }
        public ICollection<Line> Lines { get; set; }
    }
}
