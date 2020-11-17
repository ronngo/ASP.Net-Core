using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tessrt.Models.ViewModels
{
    public class PostsCreateVM
    {
        public Posts Posts { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
