﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Program
    {
        Rectangle rectangle = new Rectangle();
        Rectangle rectangle1 = new Rectangle();

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

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("That's not a valid input, please try again.\n");
                return false;
            }
            return true;
        }


        public void Go()
        {
            int newWidth = 0;
            int newLength = 0;
            string length, width;
            StartProgram:
            Console.Write("Enter the Length of Rectangle: ");
            length = Console.ReadLine();
            if (!ValidateInput(length)) goto StartProgram;
            rectangle.Length = int.Parse(length);

            Console.Write("Enter the Width of Rectangle: ");
            width = Console.ReadLine();
            if (!ValidateInput(width)) goto StartProgram;
            rectangle.Width = int.Parse(width);

            char choice;
            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1.Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit");
                Console.Write("Choice:");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        rectangle.GetLength();
                        break;

                    case '2':
                        Console.Write("\nEnter the new length of rectangle: ");
                        try
                        {
                            newLength = int.Parse(Console.ReadLine());
                            rectangle.ChangeLength(newLength);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("That's not a valid input, please try again.\n");
                            break;
                        }
                        break;

                    case '3':
                        rectangle.GetWidth();
                        break;

                    case '4':
                        Console.Write("\nEnter the new width of rectangle: ");
                        try
                        {
                            newWidth = int.Parse(Console.ReadLine());
                            rectangle.ChangeWidth(newWidth);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("That's not a valid input, please try again.\n");
                            break;
                        }
                        break;
                    case '5':
                        rectangle.GetPerimeter();
                        break;

                    case '6':
                        rectangle.GetArea();
                        break;

                    case '7':
                        break;


                    default:
                        Console.WriteLine("\nThat's not a valid input, Please select from the choices");
                        break;

                }
            } while (choice != '7');
        }
    }
}