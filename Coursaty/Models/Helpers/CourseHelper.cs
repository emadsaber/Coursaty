using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursaty.Models
{
    [MetadataType(typeof(CourseHelper))]
    public partial class Course
    {

    }
    public class CourseHelper
    {
        [DisplayName("Course Title")]
        public string title { get; set; }
        [DisplayName("Course URL")]
        [Url]
        public string link { get; set; }
        [DisplayName("Course Thumbnail")]
        public string image { get; set; }
        [Range(1,5)]
        [DisplayName("Rate")]
        public decimal rate { get; set; }
        [DisplayName("Views")]
        public decimal views { get; set; }
        [DisplayName("Course Description")]
        public string description { get; set; }
        public int instructorId { get; set; }
    }
}