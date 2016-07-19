using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using COMP123_Assignment05;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Krytia Fernandez -- 300845885
 * Date Last Modified : Juy 19, 
 * Version :  0.0.0.2 file is loading , but the menu is still up when it shows
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
                            Console.WriteLine("Displaying all student grades");
                            FileStream file = new FileStream("grades.txt", FileMode.Open, FileAccess.Read);
                            StreamReader reader = new StreamReader(file);
                            int count = 1;
                            string name;
                            ;
                            name = reader.ReadLine();
                            while (name != null)
                            {
                                Console.WriteLine("" + count + "" + name);
                                name = reader.ReadLine();
                                count++;
                            }
                            reader.Close();
                            file.Close();
                            Menu();

                            break;
                        case 2:
                            Console.ReadLine();
                            
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
        //public static void DisplayGrades()
        //{
        //    Console.WriteLine("Displaying all student grades");
        //    FileStream file = new FileStream("grades.txt", FileMode.Open, FileAccess.Read);
        //    StreamReader reader = new StreamReader(file);
        //    int count = 1;
        //    string name;
        //    ;
        //    name = reader.ReadLine();
        //    while (name != null)
        //    {
        //        Console.WriteLine("" + count + "" + name);
        //        name = reader.ReadLine();
        //        count++;
        //    }
        //    reader.Close();
        //    file.Close();
            

        //}


        
        public static void Exit()
        {

        }
    }

} //end   