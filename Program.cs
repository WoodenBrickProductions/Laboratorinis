using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace U218_Monetos
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.OutputEncoding = Encoding.UTF8;

			List<Moneta> monetos = new List<Moneta>();
			Console.WriteLine("Pirma moneta:");
			monetos.Add(GautiDuomenis());
			Console.WriteLine("Antra moneta:");
			monetos.Add(GautiDuomenis());
			Console.WriteLine("Trecia moneta:");
			monetos.Add(GautiDuomenis());
			Console.WriteLine("Cilindras:");
			Console.Write ("Iveskite cilindro auksti: ");
			double a = double.Parse (Console.ReadLine ());
			Console.Write ("Iveskite cilindro skersmeni: ");
			double b = double.Parse (Console.ReadLine ());
			Cilindras cilindras = new Cilindras ();
			cilindras.SetAukstis (a);
			cilindras.SetSkersmuo (b);
			Console.WriteLine ("Sunkiausia moneta: {0} , sunkiausios monetos nominalas: {1}",Moneta.GetSunkiausiaMoneta(monetos), Moneta.GetSunkiausiosMonetos(monetos));
			Console.WriteLine ("Bendra verte: {0}", Moneta.BendraVerte(monetos));
			Console.WriteLine("Cilindras tinka: {0}", cilindras.KuriosTelpa(monetos));
			if(cilindras.ArTelpa(monetos[0]))
				Console.WriteLine("\"{0}\" monetu vertes cilindre telpa: {1}",monetos[0].nominalas, cilindras.KiekTelpa(monetos[0]));
			if(cilindras.ArTelpa(monetos[1]))
				Console.WriteLine("\"{0}\" monetu vertes cilindre telpa: {1}",monetos[1].nominalas, cilindras.KiekTelpa(monetos[1]));
			if(cilindras.ArTelpa(monetos[2]))
				Console.WriteLine("\"{0}\" monetu vertes cilindre telpa: {1}",monetos[2].nominalas, cilindras.KiekTelpa(monetos[2]));
			Console.WriteLine("Is viso svertu: {0}", cilindras.KiekSvertu(monetos));			
			Console.WriteLine ("Pirmai monetai talpykla: {0} skersmuo, {1} aukstis", Cilindras.OptTalpykla (monetos[0]).skersmuo, Cilindras.OptTalpykla (monetos[0]).aukstis); 
			Console.WriteLine ("Antrai monetai talpykla: {0} skersmuo, {1} aukstis", Cilindras.OptTalpykla (monetos[1]).skersmuo, Cilindras.OptTalpykla (monetos[1]).aukstis); 
			Console.WriteLine ("Treciai monetai talpykla: {0} skersmuo, {1} aukstis", Cilindras.OptTalpykla (monetos[2]).skersmuo, Cilindras.OptTalpykla (monetos[2]).aukstis); 

		}


		public static Moneta GautiDuomenis()
		{
			Moneta x = new Moneta();

			Console.Write("Iveskite monetos svori: ");
			x.svoris = double.Parse(Console.ReadLine());
			Console.Write("Iveskite monetos nominala: ");
			x.nominalas = double.Parse(Console.ReadLine());
			Console.Write("Iveskite monetos stori: ");
			x.storis = double.Parse(Console.ReadLine());
			Console.Write("Iveskite monetos skersmeni: ");
			x.skersmuo = double.Parse(Console.ReadLine());
			Console.Write("Iveskite monetos kieki: ");
			x.kiekis = int.Parse(Console.ReadLine());

			return x ;

		}
	}
}




