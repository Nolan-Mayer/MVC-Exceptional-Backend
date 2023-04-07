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

        bool running = true;
        public Controller()
        {
            
            while (running)
            {
                newView.printMenu();
                string selection = newView.Menu();
                if (selection.ToLower() == "s")
                {

                    newModel.concatinateStudent(newView.getFirstName(), newView.getLastName(), newView.getRank());
                    newView.throwLists(newModel.ClassTotal, newModel.InstructorTotal);
                }
                else if (selection.ToLower() == "p")
                {
                    newModel.concatinateInstructor(newView.getFirstName(), newView.getLastName(), newView.getEmail());
                    newView.throwLists(newModel.ClassTotal, newModel.InstructorTotal);
                }
                else if (selection.ToLower() == "r")
                {
                    newView.throwLists(newModel.ClassTotal, newModel.InstructorTotal);
                } else if (selection.ToLower() == "x")
                {
                    newView.throwSortedLists(newModel.SortedList, newModel.InstructorTotal);
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

    }
}