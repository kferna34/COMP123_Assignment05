﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Krytia Fernandez -- 300845885
 * Date Last Modified : Juy 19, 
 * Version :  0.0.0.1 --- Started --- did the switch  for the menu.. 
 */ 
namespace COMP123_Assignment05
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            int InputSelection = 0;
            do
            {
                bool SelectionMenu = true; // displays the menu
                while (SelectionMenu)
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("||           Grade Viewer              ||");
                    Console.WriteLine("||                                     ||");
                    Console.WriteLine("||       1 -  Display Grades           ||");
                    Console.WriteLine("||       2 -  Exit                     ||");
                    Console.WriteLine("||                                     ||");
                    Console.WriteLine("=========================================");
                    Console.WriteLine();
                    Console.Write(" Your Choice ->  ", InputSelection);
                    InputSelection = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (InputSelection)
                    {
                        case 1:
                            Console.ReadLine();
                            DisplayGrade();
                            Console.Clear();
                            break;
                        case 2:
                            Console.ReadLine();
                            Exit();
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(" SORRY, THAT IS NOT AN OPTION, PLEASE TRY AGAIN!");

                            break;



                    }
                }
            } while (InputSelection != 2);
        }


        public static void DisplayGrade()
        {

        }
        public static void Exit()
        {

        }
    }

} //end   