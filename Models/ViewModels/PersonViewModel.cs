using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication23.Models.ViewModels
{
    public class PersonViewModel
    {
        public IEnumerable<Person> Id { get; set; }
        public IEnumerable<Person> Fullname { get; set; }
        public IEnumerable<Clock> Hour { get; set; } 
    }
}