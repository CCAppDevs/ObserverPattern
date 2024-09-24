using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class School
    {
        // properties of a school
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public bool IsSchoolOpen { get; set; }


        // methods
        public School(int num, string name)
        {
            SchoolId = num;
            SchoolName = name;
            IsSchoolOpen = true;
        }

        public void ToggleOpenStatus()
        {
            IsSchoolOpen = !IsSchoolOpen;
        }

        public void CloseSchool()
        {
            // do stuff here
            IsSchoolOpen = false;
        }
    }
}
