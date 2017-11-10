using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem {
   public class Student {
        private string _name;
        private DateTime _birthdate;
        private int _id;
        private Dictionary<int, Paper> _enrolledPapers;

        public Student(string name, int id, DateTime dob) {
            //Default Constructor, all are required.
            _name = name;
            _id = id;
            _birthdate = dob;
            _enrolledPapers = new Dictionary<int, Paper> { };

        }

        public string Name {
            get {
                return _name;
            }

            set {
                _name = value;
            }
        }

        public override string ToString() {
            //Overriding ToString so that this dictionary item can be properly displayed in a listbox.
            /*Reference to this: http://stackoverflow.com/questions/15817739/c-sharp-can-i-display-an-attribute-of-an-object-in-a-dictionary-as-listcontrol-d 
             * Using this because hours of searching MSDN led me nowhere with more questions than answers*/

            return string.Format("{0} - {1}", _id, _name);
        }

        public Dictionary<int, Paper> EnrolledPapers {
            get {
                return _enrolledPapers;
            }
        }
        public DateTime Birthdate {
            get {
                return _birthdate;
            }
            set {
                _birthdate = value;
            }
        }

        public int ID {
            get {
                return _id;
            }

            set {
                _id = value;
            }
        }

        public void AddPaperToStudent(Paper p) {
            //Add the paper to the paper dictionary.
            _enrolledPapers.Add(p.PaperID, p);
        }

        public bool CanAddPaperToStudent(Paper p) {
            //Check if the paper is already in the student dictionary.
            if (_enrolledPapers.ContainsKey(p.PaperID)) {
                return false;
            }
            return true;
        }
       
     }
}
