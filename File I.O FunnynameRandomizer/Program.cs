using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_I.O_FunnynameRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (StreamReader reader = new StreamReader(@"C:\Users\Sleazy P Martini\Desktop\readforfunnysentence.txt"))

            {

                string line1 = reader.ReadLine();

                string[] nouns = line1.Split(',');
                string line2 = reader.ReadLine();
                string[] verbs = line2.Split(',');
                string line3 = reader.ReadLine();
                string[] prep = line3.Split(',');

                while (true)
                {

                    StringBuilder MyStringBuilder = new StringBuilder();


                    int n = RandomInt(nouns.Length - 1);   //generating a random within range to select index in noun
                    int v = RandomInt(verbs.Length - 1);  //   selector in verbs
                    int p = RandomInt(prep.Length - 1);   // selector in prep
                    MyStringBuilder.Append(nouns[n] + " " + verbs[v] + " " + prep[p]);  //using string builder to join 
                    
                    Console.WriteLine(MyStringBuilder);    //printing random string 
                    using (StreamWriter writer = new StreamWriter(@"C: \Users\Sleazy P Martini\Desktop\readforfunnysentence.txt")) //writing new line to file 
                    {
                        writer.WriteLine(MyStringBuilder);
                    }

                        Console.WriteLine("Would you like to another sentence? press space bar to continue, any other key to end");
                    ConsoleKeyInfo keyPressed = Console.ReadKey();
                    if (keyPressed.Key != ConsoleKey.Spacebar)    //if spacebar is press continue any other key break line 
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }

                    
                } // while loop closing bracket
            } //stream reader closing bracket
        }  //main method closing bracket 
        static int RandomInt(int y)  //method to print number from 0-length (-1 from length) of array 
        {
            Random rnd = new Random();
            int indexSel = rnd.Next(0, y);
            return indexSel;
        }




        







   }
}
  

