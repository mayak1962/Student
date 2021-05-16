using System;

namespace Student
{
	public class Student
	{
		int id;
		double dForegn;
		double dBEL, dMath, dPhis, dChem, dBio, average;
		public string name; // ime na uchnika
		public string clas; // klasa
		public int Id
		{
			set
			{
				if (value > 0 && value <= 26) this.id = value;
				else Console.WriteLine("Niama takuw");
			}
			get { return this.id; }
		}  // nomer w klas

		public double DBEL
		{
			set
			{
				if (value >= 2.00 && value <= 6.00) this.dBEL = value;
				else Console.WriteLine("Невъзможна оценка");
			}
			get { return this.dBEL; }
		}


		public double DForeign
		{ set { this.dForegn = value; } get { return this.dForegn; } }

		public double DPhis
		{ set { this.dPhis = value; } get { return this.dPhis; } }
		public double DChem
		{ set { this.dChem = value; } get { return this.dChem; } }
		public double DBio
		{ set { this.dBio = value; } get { return this.dBio; } }
		public double DMath
		{ set { this.dMath = value; } get { return this.dMath; } }//ocenki po predmeti
		public double Average
		{ set { this.average = value; } get { return this.average; } }

	}

}
