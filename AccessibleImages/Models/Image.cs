using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessibleImages.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AlternativeText { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("UserId")]
        public virtual User Users { get; set; }
    }
}
