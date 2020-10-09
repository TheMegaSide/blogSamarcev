using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogSamarcev.ViewModels.Blog
{
    public class NewPostViewModel
    {
        [Required]
        [Display(Name ="Заголовок")]
        public string Title { get; set; }


        [Required]
        [Display(Name = "Содержание поста")]
        public string Data { get; set; }
    }
}
