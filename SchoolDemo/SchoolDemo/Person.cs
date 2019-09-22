using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo
{
    class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        private int PersonAge;

        public void SetAge(int n)
        {
            this.PersonAge = n;
        }

        public void ShowAge()
        {
            var tempString = PersonAge > 1 ? "Years" : "year";
            Console.WriteLine($"My age is: {PersonAge} {tempString} old");
        }

        public virtual void MeetPerson()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}!");
        }
    }
}
