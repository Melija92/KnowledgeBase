using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnowledgeBase.Models
{
    public class Feedback
    {
        [Required(ErrorMessage="Please Enter Full Name")]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage="Please Enter Valid Email address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Choose Feedback Type")]
        [Display(Name = "Type")]
        public string FeedbackType { get; set; }

        [Required(ErrorMessage = "Please Enter Comment")]
        [DataType(DataType.MultilineText)]
        [Display(Name="Comment")]
        public string Comment { get; set; }
    }
}