using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ClassRoster_Refactored.Model;

namespace ClassRoster_Refactored
{
    internal class Controller
    {
        View newView = new View();
        Model newModel = new Model();

        List<Student> classTotal = new List<Student>();
        List<Student> sortedList = new List<Student>();
        List<Instructor> instructorTotal = new List<Instructor>();

        bool running = true;
        public Controller()
        {

            while (running)
            {
                newView.printMenu();
                string selection = newView.Menu();
                if (selection.ToLower() == "s")
                {
                    string input1 = newView.getFirstName();
                    string input2 = newView.getLastName();
                    string input3 = newView.getRank();
                    classTotal.Add(newModel.concatinateStudent(input1,input2,input3));
                    sortedList.Add(newModel.concatinateStudent(input1,input2,input3));
                    throwLists();
                }
                else if (selection.ToLower() == "p")
                {
                    instructorTotal.Add(newModel.concatinateInstructor(newView.getFirstName(), newView.getLastName(), newView.getEmail()));
                    throwLists();
                }
                else if (selection.ToLower() == "r")
                {
                    throwLists();
                } else if (selection.ToLower() == "x")
                {
                    sortedList.Sort(new Student.SortClassByRank());
                    throwSortedLists();
                }
                else if (selection.ToLower() == "e")
                {
                    running = false;
                } 
                else
                {
                    newView.Menu();
                }
            }
        }

        public void throwLists()
        {
            foreach (Instructor currentInstructor in instructorTotal)
            {
                newView.printProfessor(currentInstructor.FirstName, currentInstructor.LastName, currentInstructor.Email);
            }
            foreach (Student currentStudent in classTotal)
            {
                newView.printStudent(currentStudent.FirstName, currentStudent.LastName, currentStudent.Rank);
            }
        }

        public void throwSortedLists()
        {
            foreach (Instructor currentInstructor in instructorTotal)
            {
                newView.printProfessor(currentInstructor.FirstName, currentInstructor.LastName, currentInstructor.Email);
            }
            foreach (Student currentStudent in sortedList)
            {
                newView.printStudent(currentStudent.FirstName, currentStudent.LastName, currentStudent.Rank);
            }
        }




    }
}