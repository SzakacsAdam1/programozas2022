using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace elsofeladatt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //letrehoz(); 
            beker();
        }
        /*static void letrehoz()
        {

            string a = " ";
            StreamWriter ir = new StreamWriter("osztaly.txt");

            do
            {
                Console.Write("Kérek egy nevet: ");
                a = Console.ReadLine();                
                ir.WriteLine(a);
            } while (a!="");

            ir.Close();
            
        }
        */



        
        static void beker()
        {
            List<string> nevek = new List<string>();
            
       
            string[] sorok = File.ReadAllLines("osztaly.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                nevek.Add(sorok[i]);
            }

            Random rand = new Random();
            rand.Next();
            //rand.Next(nevek);

            int[,] szamok = new int[1, 21];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(i + " " + nevek);
            }

          
        }

    }




    
}
