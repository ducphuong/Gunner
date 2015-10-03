using System; // instruction to say: we want to use things from System namespace
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication3
{
    class GlazerCalc
    {
        static double readValue(
            double low,
            double high,string prompt=" Give me a value",string error = "ERROR!!!")
        {
            double vDouble = 0.0;
            while(vDouble <low || vDouble > high)
            {
                Console.WriteLine(prompt + " between "+ low + " " + high);
                string vString = Console.ReadLine();
                vDouble = double.Parse(vString);
            }
            return vDouble;
        }
        
        static void Main()
        {
            /*
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;

            int[] scores = new int[11];
            
            byte x = 255;
            x = (byte) (x + 1); //cast x +1 into byte addition

            double width=0.0, height=0.0, woodlength, glassArea;
            string widthString, heightString;


            width = readValue(low:3,high:5,error:"nothing");
            height = readValue(low: 2, high: 7, prompt: "Give the height of the windows ");
            
            woodlength = (width + height) * 2 *3.25;//convert unity to cm
            glassArea = width * height;

            Console.WriteLine("the length of the wood is " + woodlength + " feet");
            Console.WriteLine("the area of the glass i " + glassArea + " square metres");
            Console.WriteLine("x is a byte {0}", x); //x = 0 here!
            Console.WriteLine(@"\x0041BCDE\a");// @ to mean that it is the text i want (understand the "\")
            //@ verbatim character
             */
            int age;
            string ageString = Console.ReadLine();
            string path;
            path = @"C:\Users\ndp\Documents\";
            StreamWriter Writer; //declare
            StreamReader Reader;
            Writer = new StreamWriter(path+"my_stream_file.txt"); //initialize
            Writer.WriteLine("HI there, it is automatic character!");
            Writer.Close();

            Reader = new StreamReader(path+"my_stream_file.txt");
            while (Reader.EndOfStream == false)
            {
                string line = Reader.ReadLine();
                Console.WriteLine(line);
            }
            Reader.Close();


            try
            {
                age = int.Parse(ageString);
                Console.WriteLine("Thank man! your age is {0}", age);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Invalid age value!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //this code will be executed no matter the code in try or catch is executed.
                string type = "C";
                switch (type.ToUpper())
                {
                    case "C":
                    case "COLD":
                        Console.WriteLine("Hi C man");
                        break;
                    case "B":
                    case "BABE":
                        break;
                    default:
                        Console.WriteLine("Default case, so borring!");
                        break;
                }
            }
        }
    }
}
