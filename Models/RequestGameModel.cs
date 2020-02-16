using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Chapter2MyApp.Models
{
    public class RequestGameModel
    {
        [Required(ErrorMessage = "Title Required")]
        [DisplayName("Game Title")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Platform Required")]
        [DisplayName("Game Platform")]
        public string Platform { get; set; }
        
        [Required(ErrorMessage = "Release Date")]
        [DisplayName("Release Date")]
        [RegularExpression(@"^\d{1,2}\/\d{1,2}\/\d{4}$", ErrorMessage = "Date format is mm/dd/yyyy.")]
        public string ReleaseDate { get; set; }




    }
}