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

        public bool CheckTitle(string title)
        {
            if (title.Any(char.IsDigit))
                return false;

            return true;
                
        }

        public bool CheckAlternativeText(string alternativeText)
        {
            if (alternativeText.Length >= 16)
                return true;

            return false;
        }
    }
}
