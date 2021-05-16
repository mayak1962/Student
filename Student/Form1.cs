using System;
using System.Windows.Forms;

namespace Student
{
	public partial class Form1 : Form
	{
		Student newStud = new Student();
		Student[] clasOf = new Student[27];
		public Form1()
		{
			InitializeComponent();
			for (int i = 1; i <= 26; i++) clasOf[i] = new Student();

		}
		private void buttonFind_Click(object sender, EventArgs e)
		{

        }
        private void buttonAverage_Click(object sender, EventArgs e)
		{
			double av = (double.Parse(textBoxBel.Text) + double.Parse(textBoxBio.Text) + double.Parse(textBoxChem.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxMatem.Text)) / 6;
			labelAverage.Text = av.ToString();
			newStud.Average = double.Parse(labelAverage.Text);
		}
		private void buttonClear_Click(object sender, EventArgs e)
		{
			textBoxClass.Text = "";
			textBoxBel.Text = "0";
			textBoxBio.Text = "0";
			textBoxChem.Text = "0";
			textBoxMatem.Text = "0";
			textBoxName.Text = "";
			textBoxPhys.Text = "0";
			textBoxId.Text = "";
			textBoxForeign.Text = "0";
			labelAverage.Text = "";
		}
		private void buttonSave_Click(object sender, EventArgs e)
		{
			int i = newStud.Id;
			if (i >= 1 && i <= 26)
			{
				newStud.clas = textBoxClass.Text; clasOf[i].clas = newStud.clas;
				newStud.Id = int.Parse(textBoxId.Text); clasOf[i].Id = newStud.Id;
				newStud.name = textBoxName.Text; clasOf[i].name = newStud.name;
				newStud.DBEL = double.Parse(textBoxBel.Text); clasOf[i].DBEL = newStud.DBEL;
				newStud.DBio = double.Parse(textBoxBio.Text); clasOf[i].DBio = newStud.DBio;
				newStud.DChem = double.Parse(textBoxChem.Text); clasOf[i].DChem = newStud.DChem;
				newStud.DMath = double.Parse(textBoxMatem.Text); clasOf[i].DMath = newStud.DMath;
				newStud.DPhis = double.Parse(textBoxPhys.Text); clasOf[i].DPhis = newStud.DPhis;
				newStud.DForeign = double.Parse(textBoxForeign.Text); clasOf[i].DForeign = newStud.DForeign;

			}

		}

	}
}
    


