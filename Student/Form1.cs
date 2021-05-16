using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
	public partial class Form1 : Form
	{
        private const string FilePath = "classFile.txt";
        Student stud = new Student();
		public Form1()
		{
			InitializeComponent();
		}
		private void buttonFind_Click(object sender, EventArgs e)
		{
			String clas = textBoxClass.Text;
			String number = textBoxId.Text;
			stud = findStundet(clas, number);
        }

        private Student findStundet(string clas, string number)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
  
            var fileLines = File.ReadAllLines(FilePath).ToList();
            foreach (var line in fileLines)
            {
                String[] studProps = line.Split(' ');
                stud.clas = studProps[0];
                stud.Id = int.Parse(studProps[1]);
                stud.name = studProps[2];
                stud.DBEL = double.Parse(studProps[3]);
                stud.DBio = double.Parse(studProps[4]);
                stud.DChem = double.Parse(studProps[5]);
                stud.DForeign = double.Parse(studProps[6]);
                stud.DMath = double.Parse(studProps[7]);
                stud.DPhis = double.Parse(studProps[8]);
                stud.Average = double.Parse(studProps[9]);
            }
        }

        private void buttonAverage_Click(object sender, EventArgs e)
		{
			double av = (double.Parse(textBoxBel.Text) + double.Parse(textBoxBio.Text) + double.Parse(textBoxChem.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxMatem.Text)) / 6;
			labelAverage.Text = av.ToString();
			stud.Average = double.Parse(labelAverage.Text);
		}
		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxClass.Text = "";
			textBoxBel.Text = "";
			textBoxBio.Text = "";
			textBoxChem.Text = "";
			textBoxMatem.Text = "";
			textBoxName.Text = "";
			textBoxPhys.Text = "";
			textBoxId.Text = "";
			textBoxForeign.Text = "";
			labelAverage.Text = "";
		}
		private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            int i = int.Parse(textBoxId.Text);
			if (i >= 1 && i <= 26)
            {
                stud.clas = textBoxClass.Text;
                stud.Id = i;
                stud.name = textBoxName.Text;
				stud.DBEL = double.Parse(textBoxBel.Text);
                stud.DBio = double.Parse(textBoxBio.Text);
                stud.DChem = double.Parse(textBoxChem.Text);
                stud.DMath = double.Parse(textBoxMatem.Text);
                stud.DPhis = double.Parse(textBoxPhys.Text); 
                stud.DForeign = double.Parse(textBoxForeign.Text);
				stud.Average = double.Parse(labelAverage.Text);
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
			Save();
			String row = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}",
				stud.clas,
				stud.Id,
				stud.name,
				stud.DBEL,
				stud.DBio,
				stud.DChem,
				stud.DForeign,
				stud.DMath,
				stud.DPhis,
				stud.Average);

			using (StreamWriter sw = new StreamWriter(FilePath, false, Encoding.Unicode))
            {
				sw.WriteLine(row);
			}
        }
    }
}
    


