using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster_Refactored
{
    internal class Model
    {
        public class Person
        {
            private string firstname;
            private string lastname;
            public string FirstName
            {
                get { return firstname; }
                set { firstname = value; }
            }

            public string LastName
            {
                get { return lastname; }
                set { lastname = value; }
            }
        }

        public class Student : Person
        {
            private string rank;

            public string Rank
            {
                get { return rank; }
                set { rank = value; }
            }

            public class SortClassByRank : IComparer<Student>
            {
                public int Compare(Student a, Student b)
                {

                    if (Convert.ToInt32(a.Rank) > Convert.ToInt32(b.Rank))
                    {
                        return 1;
                    }
                    else if (Convert.ToInt32(a.Rank) < Convert.ToInt32(b.Rank))
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }

        public class Instructor : Person
        {
            private string email;

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

        }

        public Student concatinateStudent(string firstname, string lastname, string rank)
        {
            Student newStudent = new Student();
            newStudent.FirstName = firstname;
            newStudent.LastName = lastname;
            newStudent.Rank = rank;

            return newStudent;
        }

        public Instructor concatinateInstructor(string firstname, string lastname, string email)
        {
            Instructor newInstructor = new Instructor();
            newInstructor.FirstName = firstname;
            newInstructor.LastName = lastname;
            newInstructor.Email = email;

            return newInstructor;
        }

    }
}
