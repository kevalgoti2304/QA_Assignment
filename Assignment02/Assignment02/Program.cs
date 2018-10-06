using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        TriangleSolver triangle = new TriangleSolver();

        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.Go();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static bool ValidateInput(string input)
        {
            var inputArray = input.ToCharArray();

            foreach (char c in inputArray)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("That's not a valid input, please try again.\n");
                    return false;
                }
            }

            if ((String.IsNullOrWhiteSpace(input)))
            {
                Console.WriteLine("That's not a valid input, please try again.\n");
                return false;
            }
            return true;
        }

        public void Go()
        {
            string a, b, c;
            int dimensionOne, dimensionTwo, dimensionThree;
            char choice;
            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                Console.Write("Choice:");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        Console.WriteLine("\nEnter the dimensions of triangle: ");
                        StartProgram1:
                        Console.Write("Enter the 1st dimension: ");
                        a = Console.ReadLine();
                        if (!ValidateInput(a))
                        {
                            goto StartProgram1;
                        }

                        StartProgram2:
                        Console.Write("Enter the 2nd dimension: ");
                        b = Console.ReadLine();
                        if (!ValidateInput(b))
                        {
                            goto StartProgram2;
                        }

                        StartProgram3:
                        Console.Write("Enter the 3rd dimension: ");
                        c = Console.ReadLine();
                        if (!ValidateInput(c))
                        {
                            goto StartProgram3;
                        }
                        dimensionOne = int.Parse(a);
                        dimensionTwo = int.Parse(b);
                        dimensionThree = int.Parse(c);

                        if (dimensionOne + dimensionTwo > dimensionThree
                               && dimensionOne + dimensionThree > dimensionTwo
                               && dimensionTwo + dimensionThree > dimensionOne)
                        {
                            string result = triangle.Analyze(dimensionOne, dimensionTwo, dimensionThree);

                            Console.WriteLine("This is an {0} triangle.",result);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid triangle.");
                            break;
                            
                        } 
                                           
                    case '2':
                        break;

                    default:
                        Console.WriteLine("\nThat's not a valid input, Please select from the choices");
                        break;

                }
            } while (choice != '2');
        }
    }
}
