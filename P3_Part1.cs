using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string C_input = "..\\..\\TextFile.txt";
            StreamReader reader = new StreamReader(C_input);
            List<Narys> nariai = new List<Narys>();
            GetInput(nariai, reader);
            Console.WriteLine("Viso pinigu: {0,4:f2}", Narys.KiekVisi(nariai));
            Console.WriteLine("Viso vienam: {0,4:f2}", Narys.Vidurkis(nariai));
            Console.WriteLine("Viso is nariu: {0,4:f2}", Narys.KiekSurinkta(nariai));
        }


        public static void GetInput(List<Narys> nariai, StreamReader reader)
        {
            int n;

            using (reader)
            {
               n = int.Parse(reader.ReadLine());
               for(int i = 0; i < n; i ++)
                {
                    string[] x = reader.ReadLine().Split() ;
                    nariai.Add(new Narys(int.Parse(x[0]), int.Parse(x[1])));
                }
            }

        }



    }

  class Narys
    {
        private int eurai;
        private int centai;


        public Narys(int eurai, int centai)
        {
            this.eurai = eurai;
            this.centai = centai;

        }

        public static double KiekVisi(List<Narys> nariai)
        {
            double kiekE = 0;
            int kiekC = 0;

            foreach (Narys x in nariai)
            {
                kiekE += x.eurai;
                kiekC += x.centai;
            }

            return kiekE + (double)(kiekC) / 100;

        }

        public static double Vidurkis(List<Narys> nariai)
        {
            double kiekE = 0;
            int kiekC = 0;

            foreach (Narys x in nariai)
            {
                kiekE += x.eurai;
                kiekC += x.centai;
            }

            return (kiekE + (double)(kiekC) / 100) / nariai.Count;

        }

        public static double KiekSurinkta(List<Narys> nariai)
        {
            int kiekE = 0;
            int kiekC = 0;

            foreach (Narys x in nariai)
            {
                kiekE += x.eurai;
                kiekC += x.centai;
            }

            return ((kiekE) + (double)(kiekC) / 100) / 4;

        }


        public int GetEurai()
        {
            return eurai;
        }

        public int GetCentai()
        {
            return centai;
        }


    }



}
