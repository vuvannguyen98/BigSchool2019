using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage ="Place không được bỏ trống")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Place không được bỏ trống")]
        public string Date  { get; set; }

        [Required(ErrorMessage = "Place không được bỏ trống")]
        public string Time  { get; set; }

        [Required(ErrorMessage = "Place không được bỏ trống")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}