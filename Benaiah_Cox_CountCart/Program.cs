using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benaiah_Cox_CountCart
{
    class Program
    {/* Benaiah Cox 
        may 12th
        Count Cart
        /*/
        static void Main(string[] args)
        {// Prompt 
            int then;
            int imp = 0;
           // Display and verification
            string[] maschine = new string[] { "snack", "drink", "vegatable", "drink", "meat", "snack", "vegatable", "snack", "drink", "drink" };
            Console.WriteLine("Choose(1) for Snacks, (2) for Drinks, (3) for Vegetables, and(4) for Meats");
            string inp = Console.ReadLine();

            //Verification
            while (!int.TryParse(inp, out imp))
            {

                Console.WriteLine("Please Enter A number");
                inp = Console.ReadLine();

            }
            int conut = 0;

            if (inp == "1" || inp == "2" || inp == "3" || inp == "4")
            {
                Console.WriteLine("Thank you");

            }
            // Creating  a reacatch  in case of invalid entry
            else (Console.WriteLine( "Please enter a valid nuber ")
                    {



                Console.WriteLine("Choose(1) for Snacks, (2) for Drinks, (3) for Vegetables, and(4) for Meats");
                inp = Console.ReadLine();
            }
            // if loop to display result for 1 input
             if (inp == "1")
            {


                for (int i = 0; i < maschine.Length; i++)
                {
                    
                    if (maschine[i] == maschine[0])
                   {
                        conut++;
                    }
                    Console.WriteLine(" in the shopping cart there are " + conut + "snacks");
                }
            }
            // if loop to display result for 2 input
            else if (inp == "2")
            {


                for (int i = 0; i < maschine.Length; i++)
                {

                    if (maschine[i] == maschine[2])
                    {
                        conut++;
                    }
                    Console.WriteLine(" in the shopping cart there are " + conut + " drinks");

                }
            }
            // if loop to display result for 3 input
            else if (inp == "3")
            {


                for (int i = 0; i < maschine.Length; i++)
                {

                    if (maschine[i] == maschine[3])
                    {
                        conut++;
                    }
                    Console.WriteLine(" in the shopping cart there are " + conut + " vegetables");
                }
            }
            // if loop to display result for 4 input
            else if (inp == "4")
            {


                for (int i = 0; i < maschine.Length; i++)
                {

                    if (maschine[i] == maschine[5])
                    {
                        conut++;
                    }
                    Console.WriteLine(" in the shopping cart there are " + conut + " meats");
                }
            }
        }
    }
}
