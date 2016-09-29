using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace U218_Monetos
{
	
	public class Moneta
	{

		public double nominalas {  set; get; }
		public double svoris {  set; get; }
		public double storis {  set; get;}
		public double skersmuo {  set; get; }
		public int kiekis { set; get; }
		



		public Moneta(double nominalas, double svoris, double storis,double skersmuo, int kiekis)
		{
					
			this.nominalas = nominalas;
			this.svoris = svoris;
			this.storis = storis;
			this.kiekis = kiekis;
			this.skersmuo = skersmuo;
		}
		

		public Moneta()

		{
			this.nominalas = 0;
			this.svoris = 0;
			this.storis = 0;
			this.kiekis = 0;
			this.skersmuo = 0;		
		
		}


		public static string GetSunkiausiosMonetos(List<Moneta> list) 
		{
			Moneta y = new Moneta();
			string re = "";
		
			foreach (Moneta x in list) 
			{
				if ((x.svoris > y.svoris)) 
				{
					y = x;
				}
			}

			re += System.Convert.ToString(y.nominalas);

			foreach (Moneta x in list) 
			{
				if ((x.svoris == y.svoris)&&(x.nominalas != y.nominalas)) 
				{
					{
						re += " ir " + System.Convert.ToString(x.nominalas);
					}

				}

			}

			return re;


		}

		public static double GetSunkiausiaMoneta(List<Moneta> list)
		{
			double y = 0;

			foreach (Moneta x in list) 
			{
				if ((x.svoris > y)) 
				{
					y = x.svoris;
				}
			}

			return y;
		}

		public double GetIlgis()
		{
			return skersmuo * Math.PI;
		}
	

		public static double BendraVerte(List<Moneta> list)
		{

			double kiek = 0;

			foreach(Moneta x in list) 
			{
				kiek += x.nominalas;
			}

			return kiek;

		}

	

		

	}

}