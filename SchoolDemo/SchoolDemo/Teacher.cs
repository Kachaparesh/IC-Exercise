using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo
{
    class Teacher : Person
    {
        public Student student { get; set; }
        public string Subject { get; set; }
        public void Explain(string subject)
        {
            Console.WriteLine($"Explanation of {subject} begins.");
        }

        public override void MeetPerson()
        {
            base.MeetPerson();
            Console.WriteLine($"Teacher of {student.FirstName} {student.LastName}");
            base.ShowAge();
        }
    }
}
