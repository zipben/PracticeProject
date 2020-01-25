using System;
using System.ComponentModel.DataAnnotations;
using Practice_Project.Interfaces;

namespace Practice_Project.Models
{
    public class IndexViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }

        public IndexViewModel()
        {
            this.FirstName = "";
            this.LastName = "";
        }
    }
}