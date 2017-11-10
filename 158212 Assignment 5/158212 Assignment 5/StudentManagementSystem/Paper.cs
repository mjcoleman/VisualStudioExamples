using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem{
   public class Paper {
        private string _paperName;
        private int _paperId;
        private string _paperCoordinator;
        private Dictionary<int, Student> _studentsInPaper;

        public Paper(string name, int id, string coordinator) {
            //Default constructor, all are required.
            _paperName = name;
            _paperId = id;
            _paperCoordinator = coordinator;
            _studentsInPaper = new Dictionary<int, Student> { };
        }

        public Dictionary<int, Student> StudentsInPaper {
            get {
                return _studentsInPaper;
            }
        }


        public string PaperName {
            get {
                return _paperName;
            }
            set {
                _paperName = value;
            }
        }

        public override string ToString() {
            //Overriding ToString so that this dictionary item can be properly displayed in a listbox.
            /*Reference to this: http://stackoverflow.com/questions/15817739/c-sharp-can-i-display-an-attribute-of-an-object-in-a-dictionary-as-listcontrol-d 
             * Using this because hours of searching MSDN led me nowhere with more questions than answers*/
            return String.Format("{0} - {1}", _paperId, _paperName);

        }

        public int PaperID {
            get {
                return _paperId;
            }

            set {
                _paperId = value;
            }
        }

        public string PaperCoordinator {
            get {
                return _paperCoordinator;
            }
            set {
                _paperCoordinator = value;
            }
        }

        public void AddStudentToPaper(Student s) {
            //Add a student to the student dictionary of enrolled students.
            _studentsInPaper.Add(s.ID, s);
        }

    }
}
