﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public override void MeetPerson()
        {
            base.MeetPerson();
            Console.WriteLine("I am a Student");
        }
    }
}
