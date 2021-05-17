using System;
using System.Collections.Generic;

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


        public override string ToString()
        {
			return String.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}; {7}; {8}; {9}",
									this.clas,
									this.Id,
									this.name,
									this.DBEL,
									this.DBio,
									this.DChem,
									this.DForeign,
									this.DMath,
									this.DPhis,
									this.Average);
		}

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   clas == student.clas &&
                   Id == student.Id;
        }

        public override int GetHashCode()
        {
            int hashCode = 1324468247;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + dForegn.GetHashCode();
            hashCode = hashCode * -1521134295 + dBEL.GetHashCode();
            hashCode = hashCode * -1521134295 + dMath.GetHashCode();
            hashCode = hashCode * -1521134295 + dPhis.GetHashCode();
            hashCode = hashCode * -1521134295 + dChem.GetHashCode();
            hashCode = hashCode * -1521134295 + dBio.GetHashCode();
            hashCode = hashCode * -1521134295 + average.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(clas);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + DBEL.GetHashCode();
            hashCode = hashCode * -1521134295 + DForeign.GetHashCode();
            hashCode = hashCode * -1521134295 + DPhis.GetHashCode();
            hashCode = hashCode * -1521134295 + DChem.GetHashCode();
            hashCode = hashCode * -1521134295 + DBio.GetHashCode();
            hashCode = hashCode * -1521134295 + DMath.GetHashCode();
            hashCode = hashCode * -1521134295 + Average.GetHashCode();
            return hashCode;
        }
    }

}
