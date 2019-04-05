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
        [Required(ErrorMessage ="Địa điểm -- không được để trống")]
        public string Place { get; set; }
            
        [Required(ErrorMessage = "Ngày -- không được để trống")]
        [FutureDate(ErrorMessage = "Định dạng sai  (dd/MM/YYYY)")] 
        public string Date  { get; set; }

        [Required(ErrorMessage = "Thời gian -- không được để trống")]
        [ValidTime(ErrorMessage = "Định dạng sai (hh:mm)")]
        public string Time  { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn -- Thể loại")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}