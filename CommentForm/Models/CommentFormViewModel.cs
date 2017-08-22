using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentForm.Models
{
    public class CommentFormViewModel
    {
        public Comment Comment { get; set; }
        public Procedure Procedure { get; set; }
    }
}