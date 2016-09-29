using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace U218_Monetos
{
	class Cilindras
	{
		public double aukstis { get; private set; }
		public double skersmuo { get; private set; }



		public Cilindras(double aukstis, double skersmuo)
		{
			this.aukstis = aukstis;
			this.skersmuo = skersmuo;
		}

		public Cilindras() {

		}

		public double GetIlgis()
		{
			return skersmuo * Math.PI;
		}

		public bool ArTelpa(Moneta moneta)
		{
			if (moneta.GetIlgis() < GetIlgis()) return true;
			else return false;
			//TODO: Jei netelpa iskarti ismesti is ciklo
		}

		public string KuriosTelpa(List<Moneta> monetos)
		{
			string re = "";

			foreach (Moneta x in monetos)
			{
				
				if (ArTelpa(x)) 
				{
					re += "\"" + x.nominalas+ "\"" + " vertes nominalas  ";
				}
			}

			return re;

		}


		public int KiekTelpa(Moneta moneta)
		{

			return (int) (aukstis / moneta.storis);

		}

		public double KiekSvertu(List<Moneta> monetos)
		{
			double kiek = 0;

			foreach (Moneta x in monetos) 
			{
				if(ArTelpa(x))
					kiek+= KiekTelpa (x) * x.svoris;
			
			}

			return kiek;	
		}


		public static Cilindras OptTalpykla(Moneta moneta)
		{
			return new Cilindras(moneta.kiekis * moneta.storis, moneta.skersmuo);
		}

		public void SetAukstis(double aukstis)
		{
			this.aukstis = aukstis;
		}

		public void SetSkersmuo(double skersmuo)
		{
			this.skersmuo = skersmuo;
		}

	}

}