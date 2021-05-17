using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        private const string FilePath = "classFile.txt";
        Student stud;
        public Form1()
        {
            InitializeComponent();
            stud = new Student();
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            String clas = textBoxClass.Text;
            String number = textBoxId.Text;
            stud = findStundet(clas, number);

            if (stud != null)
            {
                textBoxClass.Text = stud.clas;
                textBoxBel.Text = stud.DBEL.ToString();
                textBoxBio.Text = stud.DBio.ToString();
                textBoxChem.Text = stud.DChem.ToString();
                textBoxMatem.Text = stud.DMath.ToString();
                textBoxName.Text = stud.name;
                textBoxPhys.Text = stud.DPhis.ToString();
                textBoxId.Text = stud.Id.ToString();
                textBoxForeign.Text = stud.DForeign.ToString();
                labelAverage.Text = stud.Average.ToString();
            }
        }

        private Student findStundet(string clas, string number)
        {
            List<Student> students = LoadStudents();
            return students.Find(s => s.clas.Equals(clas) && s.Id.Equals(int.Parse(number)));
        }

        private List<Student> LoadStudents()
        {

            List<Student> students = new List<Student>();
            if (File.Exists(FilePath))
            {
                var fileLines = File.ReadAllLines(FilePath).ToList();
                foreach (var line in fileLines)
                {
                    Student stud = new Student();
                    String[] studProps = line.ToString().Split(';');
                    stud.clas = studProps[0].Trim();
                    stud.Id = int.Parse(studProps[1].Trim());
                    stud.name = studProps[2].Trim();
                    stud.DBEL = double.Parse(studProps[3].Trim());
                    stud.DBio = double.Parse(studProps[4].Trim());
                    stud.DChem = double.Parse(studProps[5].Trim());
                    stud.DForeign = double.Parse(studProps[6].Trim());
                    stud.DMath = double.Parse(studProps[7].Trim());
                    stud.DPhis = double.Parse(studProps[8].Trim());
                    stud.Average = double.Parse(studProps[9].Trim());

                    students.Add(stud);
                }
            }

            return students;
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            double av = GetAverage();
            labelAverage.Text = av.ToString();
            stud.Average = av;

        }

        private double GetAverage()
        {
            return (double.Parse(textBoxBel.Text) + double.Parse(textBoxBio.Text) + double.Parse(textBoxChem.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxMatem.Text)) / 6;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxClass.Clear();
            textBoxBel.Clear();
            textBoxBio.Clear();
            textBoxChem.Clear();
            textBoxMatem.Clear();
            textBoxName.Clear();
            textBoxPhys.Clear();
            textBoxId.Clear();
            textBoxForeign.Clear();
            labelAverage.Text = string.Empty;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            GetAverage();
            Save();
            var students = LoadStudents();
            if (students.Count == 0)
            {
                using (StreamWriter sw = new StreamWriter(FilePath, false, Encoding.Unicode))
                {
                    sw.WriteLine(GetStudentFromForm().ToString());
                }
            }
            else
            {
                var studentsInFile = LoadStudents();
                var formStudent = GetStudentFromForm();

                var oldStudent = studentsInFile.FirstOrDefault(s => s.Id == formStudent.Id && s.clas == formStudent.clas);
                var index = studentsInFile.IndexOf(oldStudent);
                if (index != -1)
                {
                    studentsInFile[index] = formStudent;
                } else
                {
                    studentsInFile.Add(formStudent);
                }

                using (StreamWriter sw = new StreamWriter(FilePath, false, Encoding.Unicode))
                {
                    foreach (var student in studentsInFile)
                    {
                        sw.WriteLine(student.ToString());
                    }
                }
            }
        }

        private void Save()
        {
            int i = int.Parse(textBoxId.Text);
            if (i >= 1 && i <= 26)
            {
                stud = GetStudentFromForm();
            }
        }

        private Student GetStudentFromForm()
        {
            Student stud = new Student();
            stud.clas = textBoxClass.Text;
            stud.Id = int.Parse(textBoxId.Text);
            stud.name = textBoxName.Text.Trim();
            stud.DBEL = double.Parse(textBoxBel.Text);
            stud.DBio = double.Parse(textBoxBio.Text);
            stud.DChem = double.Parse(textBoxChem.Text);
            stud.DMath = double.Parse(textBoxMatem.Text);
            stud.DPhis = double.Parse(textBoxPhys.Text);
            stud.DForeign = double.Parse(textBoxForeign.Text);
            stud.Average = double.Parse(labelAverage.Text);

            return stud;
        }
    }
}



