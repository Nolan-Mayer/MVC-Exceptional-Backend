using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster_Refactored
{
    internal class Model
    {
        List<Student> classTotal = new List<Student>();
        List<Student> sortedList = new List<Student>();
        List<Instructor> instructorTotal = new List<Instructor>();

        public List<Student> ClassTotal
        {
            get { return classTotal; }
            set { classTotal = value; }
        }

        public List<Student> SortedList
        {
            get { return sortedList; }
            set { sortedList = value; }
        }

        public List<Instructor> InstructorTotal
        {
            get { return instructorTotal; }
            set { instructorTotal = value; }
        }

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

        public void concatinateStudent(string firstname, string lastname, string rank)
        {
            Student newStudent = new Student();
            newStudent.FirstName = firstname;
            newStudent.LastName = lastname;
            newStudent.Rank = rank;

            addToList(newStudent);
            addToListToSort(newStudent);

        }

        public void concatinateInstructor(string firstname, string lastname, string email)
        {
            Instructor newInstructor = new Instructor();
            newInstructor.FirstName = firstname;
            newInstructor.LastName = lastname;
            newInstructor.Email = email;

            addInstructorToList(newInstructor);

        }

        public List<Student> addToList(Student i)
        {
            classTotal.Add(i);
            return classTotal;
        }

        public List<Instructor> addInstructorToList(Instructor i)
        {
            instructorTotal.Add(i);
            return instructorTotal;
        }

        public List<Student> addToListToSort(Student i)
        {
            sortedList.Add(i);
            sortedList.Sort(new Student.SortClassByRank());
            return sortedList;
        }

    }
}
