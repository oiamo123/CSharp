using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieData
{
    public class Genre
    {
        [StringLength(1)]
        public string GenreId { get; set; }

        [Required(ErrorMessage = "Genre name is required")]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
