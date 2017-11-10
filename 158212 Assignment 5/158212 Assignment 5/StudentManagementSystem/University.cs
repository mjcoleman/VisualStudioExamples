using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentManagementSystem {
    public class University {
        //Objects for the name of the uni, and dictionarys to hold the students and papers contained.
        private string _uniName;
        private Dictionary<int, Paper> _papers;
        private Dictionary<int, Student> _students;

        public string UniName {
            get {
                return _uniName;
            }
            set {
                _uniName = value;
            }
        }

        public Dictionary<int, Paper> Papers {
            get {
                return _papers;
            }
        }

        public Dictionary<int, Student> Students {
            get {
                return _students;
            }
        }

        public University(string name ="") {
            //Default Constructor
            _uniName = name;
            _papers = new Dictionary<int, Paper> { };
            _students = new Dictionary<int, Student> { };
        }  

        public void AddNewPaper(Paper p) {
            //Add Paper to the Dictionary
            _papers.Add(p.PaperID, p);
        }

        public void AddNewStudent(Student s) {
            //Add Student to the Dictionary
            _students.Add(s.ID, s);
        }

        public bool CheckIfStudentAlreadyExists(int id) {
            //Check if the student exists in the student dict.
            if (_students.ContainsKey(id)) {
                return true;
            }
            return false;
        }

        public bool CheckIfPaperAlreadyExists(int id, string name) {
            //Check if the paper exists in the paper dict.
            if (_papers.ContainsKey(id)) {
                return true;
            }
            return false;
        }


        public bool WriteDataToFile(FileStream fs) {
            //One at a time writes the Uni name, the students in _students, and the papers (with enrollment details) in _papers to a file.
            StreamWriter writer;
            writer = new StreamWriter(fs);

            writer.WriteLine(_uniName);
            writer.WriteLine("<STUDENTS>");

            foreach (KeyValuePair<int, Student> s in _students) {
                writer.WriteLine("<STUDENT>");
                writer.WriteLine(s.Key);
                writer.WriteLine(s.Value.Name);
                writer.WriteLine(s.Value.Birthdate);
                writer.WriteLine("</STUDENT>");
            }
            writer.WriteLine("</STUDENTS>");

            writer.WriteLine("<PAPERS>");

            foreach (KeyValuePair<int, Paper> p in _papers) {
                writer.WriteLine("<PAPER>");
                writer.WriteLine(p.Key);
                writer.WriteLine(p.Value.PaperName);
                writer.WriteLine(p.Value.PaperCoordinator);
                writer.WriteLine("<ENROLLED>");

                foreach (KeyValuePair<int, Student> s in p.Value.StudentsInPaper) {
                    writer.WriteLine("<ENROLLEDSTUDENT>");
                    writer.WriteLine(s.Key);
                    writer.WriteLine("</ENROLLEDSTUDENT>");
                }
                writer.WriteLine("</ENROLLED>");
            }

            writer.WriteLine("</PAPERS>");
            writer.Close();
            return true;
        }

        public bool ReadUniversityFromFile(FileStream fs) {
            //One at a time reads the name, students and papers (with enrollment details) into _students and _papers.
            StreamReader reader;
            reader = new StreamReader(fs);
                
                _uniName = reader.ReadLine();

                if (reader.ReadLine() == "<STUDENTS>") {
                    while (reader.ReadLine() != "</STUDENTS>") {
                        int id = Convert.ToInt32(reader.ReadLine());
                        string name = reader.ReadLine();
                        DateTime dob = Convert.ToDateTime(reader.ReadLine());
                        Student s = new Student(name, id, dob);
                        _students.Add(s.ID, s);
                        reader.ReadLine();
                    }
                }

                if (reader.ReadLine() == "<PAPERS>") {
                    while (reader.ReadLine() != "</PAPERS>") {
                        int paperID = Convert.ToInt32(reader.ReadLine());
                        string paperName = reader.ReadLine();
                        string paperCoordinator = reader.ReadLine();
                        Paper p = new Paper(paperName, paperID, paperCoordinator);
                        _papers.Add(p.PaperID, p);
                        if (reader.ReadLine() == "<ENROLLED>") {
                            while (reader.ReadLine() != "</ENROLLED>") {
                                int studentID = Convert.ToInt32(reader.ReadLine());
                                _papers[p.PaperID].AddStudentToPaper(_students[studentID]);
                                _students[studentID].AddPaperToStudent(_papers[p.PaperID]);
                                reader.ReadLine();
                            }
                        }
                    }
                }
                reader.Close();
                return true;
            }


        public bool EnrollAStudentInAPaper(Student s, Paper p) {
            //Enroll a student in the chosen paper if possible.
            if (s.CanAddPaperToStudent(p)) {
                p.AddStudentToPaper(s);
                s.AddPaperToStudent(p);
            } else {
                return false;
            }
            return true;
        }
        
      }
    }
