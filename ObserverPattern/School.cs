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
        // jesse made a change to illustrate git
        public bool IsSchoolOpen { get; set; }

        public List<ISchoolStatusSubscriber> Subscribers { get; set; }

        // methods
        public School(int num, string name)
        {
            SchoolId = num;
            SchoolName = name;
            IsSchoolOpen = true;
            Subscribers = new List<ISchoolStatusSubscriber>();
        }

        public void ToggleOpenStatus()
        {
            IsSchoolOpen = !IsSchoolOpen;
            Notify();
        }

        public void CloseSchool()
        {
            // do stuff here
            IsSchoolOpen = false;
            Notify();
        }

        public void Register(ISchoolStatusSubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Unregister(ISchoolStatusSubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (ISchoolStatusSubscriber subscriber in Subscribers)
            {
                subscriber.Update(IsSchoolOpen);
            }
        }
    }
}
