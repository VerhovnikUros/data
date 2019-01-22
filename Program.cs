using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        public static List<Department> razporedtip(List<Department> list, tipDela tip)
        {

            List<Department> naIme = new List<Department>();


            naIme = list.FindAll(c => c.tipDela == tip ).ToList();
            return naIme;
        }
        public static double razporedurna(List<Department> list)
        {

            double d;
            List<Department> naIme = new List<Department>();


            
                    d = list.Max(a => a.postavka);



              

            return 0;
        }
        public static List<Department> razporedime(List<Department> list)
        {

            List<Department> naIme = new List<Department>();


            naIme = list.OrderBy(c => c.ime).ToList();
            return naIme;
        }
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"C:\Users\Uroš\Desktop\NP2018_Podatki_Test_avgust.csv");

            List<Department> aa = new List<Department>();
            foreach(var a in lines.Skip(1))
            {
                var s = a.Split(',');
               
                if (s[5] == "Programiranje")
                {
                    if (s[3] != "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, 0, Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), 0));
                    else if (s[3] != "" && s[6] == "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, 0, 0));
                    else if (s[3] != "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, 0, Convert.ToDouble(s[7])));
                    else if (s[3] != "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Programiranje, Convert.ToInt32(s[6]), 0));
                    else
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Programiranje, 0, 0));
                }
                else if (s[5] == "Proizvodnja")
                {
                    if (s[3] != "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), double.Parse(s[7], System.Globalization.CultureInfo.InvariantCulture)));
                    else if (s[3] == "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, 0, Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), 0));
                    else if (s[3] != "" && s[6] == "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, 0, 0));
                    else if (s[3] != "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, 0, Convert.ToDouble(s[7])));
                    else if (s[3] != "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Proizvodnja, Convert.ToInt32(s[6]), 0));
                    else
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Proizvodnja, 0, 0));
                }
                else if (s[5] == "Administracija")
                {
                    if (s[3] != "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, 0, Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, Convert.ToInt32(s[6]), 0));
                    else if (s[3] != "" && s[6] == "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, 0, 0));
                    else if (s[3] != "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, 0, Convert.ToDouble(s[7])));
                    else if (s[3] != "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Administracija, Convert.ToInt32(s[6]), 0));
                    else
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Administracija, 0, 0));
                }
                else if (s[5] == "Strezba")
                {
                    if (s[3] != "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, Convert.ToInt32(s[6]), double.Parse(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, 0, double.Parse(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, Convert.ToInt32(s[6]), 0));
                    else if (s[3] != "" && s[6] == "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, 0, 0));
                    else if (s[3] != "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, 0, double.Parse(s[7])));
                    else if (s[3] != "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.Strezba, Convert.ToInt32(s[6]), 0));
                    else
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.Strezba, 0, 0));
                }
                else 
                {
                    if (s[3] != "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, Convert.ToInt32(s[6]), Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, 0, Convert.ToDouble(s[7])));
                    else if (s[3] == "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, Convert.ToInt32(s[6]), 0));
                    else if (s[3] != "" && s[6] == "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, 0, 0));
                    else if (s[3] != "" && s[6] == "" && s[7] != "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, 0, Convert.ToDouble(s[7])));
                    else if (s[3] != "" && s[6] != "" && s[7] == "")
                        aa.Add(new Department(s[0], s[1], s[2], Convert.ToInt32(s[3]), s[4], tipDela.brez, Convert.ToInt32(s[6]), 0));
                    else
                        aa.Add(new Department(s[0], s[1], s[2], 0, s[4], tipDela.brez, 0, 0));
                }


            }
            foreach(var a in aa)
                Console.WriteLine(a.postavka);
            Console.WriteLine(aa);

            List<Department> qq = new List<Department>();
           double d= razporedurna(aa);
        }
    }
   
    public enum tipDela
    { Strezba, Administracija, Proizvodnja, Programiranje,brez}
    public class Department
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public string naziv { get; set; }
        public int leto { get ; set; }
        public string emso { get; set; }
        public tipDela tipDela { get; set; }
        public int maticna { get; set; }
        public double postavka { get; set; }

        public Department(string ime, string priimek, string naziv, int leto,string emso, tipDela tipDela,int maticna,double postavka)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.naziv = naziv;
            this.leto = leto;
            this.emso = emso;
            this.tipDela = tipDela;
            this.maticna = maticna;
            this.postavka = postavka;
        }
    }
}
