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
 * Version :  0.0.0.4 ==some descritions and the exception is created but not working..
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

                            DisplayGrades();// refers to the method to open and show the file grade.txt
                            Console.WriteLine("Please press enter to go back to the selection menu ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            Exit();
                            SelectionMenu = false;
                            break;
                        default:
                            Console.WriteLine(" SORRY, THAT IS NOT AN OPTION, PLEASE TRY AGAIN! --Press ENTER to show the menu");
                            SelectionMenu = true;
                            Console.ReadKey();

                            break;
                    }
                }
            } while (InputSelection != 2);
        }
        public static void DisplayGrades()
        {
            Console.Write(" Enter File name : ");
            if (Console.ReadLine().Equals("grades.txt"))
                try
                {
                    Loading();
                    Console.WriteLine(" File Loaded ");
                    FileStream file = new FileStream("grades.txt", FileMode.Open, FileAccess.Read);//looks for the file grades.txt, then display it to the user
                    StreamReader reader = new StreamReader(file);
                    int count = 1;// the count or the numbering mode
                    string theGradeFile;//declare the var

                    theGradeFile = reader.ReadLine();
                    while (theGradeFile != null)
                    {
                        Console.WriteLine("" + count + "" + theGradeFile);
                        theGradeFile = reader.ReadLine();
                        count++;
                    }
                    reader.Close();
                    file.Close();

                }

                catch (Exception e)
                {
                    Console.WriteLine("ERROR NO SUCH FILE");

                }

        }

        public static void Loading()
        {
            Console.WriteLine("Loading the File............................");
            Console.WriteLine("......................................................");
            Console.WriteLine("................................................................");
            Console.WriteLine();

        }

        public static void Exit()
        {
            Console.WriteLine(" Press Enter to exit ");
        }
    }

} //end   