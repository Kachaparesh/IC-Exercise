using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args);
            Array.ForEach(args, Console.WriteLine);

            var myDetail = new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            };
            myDetail.MeetPerson();

            var studentDetail = new Student()
            {
                FirstName = myDetail.FirstName,
                LastName = myDetail.LastName
            };
            studentDetail.MeetPerson();
            studentDetail.SetAge(21);
            studentDetail.ShowAge();
            studentDetail.GoToClasses();

            var myTeacher = new Teacher()
            {
                FirstName = "Paul",
                LastName = "Bulton",
                student = studentDetail
            };
            myTeacher.SetAge(30);
            myTeacher.MeetPerson();
            myTeacher.Explain("Maths");

            Console.ReadLine();

        }
    }
}
