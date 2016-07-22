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
                    try
                    {
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
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Press any key to return to menu.",e.Message);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            } while (InputSelection != 2);
        }
        public static void DisplayGrades()
        {
            const char DELIM = ',';
            const string FILENAME = "grades.txt";

            FileStream file = null;
            StreamReader reader = null;

            string recordInfo;
            string[] fields;

            Grades[] grades = new Grades[3];
            Console.Write(" Enter File name : ");
            if (Console.ReadLine().Equals(FILENAME))
            {
                try
                {
                    Loading();
                    file = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);//looks for the file grades.txt, then display it to the user
                    reader = new StreamReader(file);
                    recordInfo = reader.ReadLine();
                    Console.WriteLine(" File Loaded ");

                    try
                    {
                        int count = 0;// the count or the numbering mode
                        while (recordInfo != null)
                        {
                            Grades newGrade = new Grades();
                            //Splits the long string from recordInfo and place them into the fields array 
                            fields = recordInfo.Split(DELIM);
                            newGrade.LName = fields[0];
                            newGrade.FName = fields[1];
                            newGrade.Grade = fields[2];

                            grades[count] = newGrade;
                            //reads new line
                            recordInfo = reader.ReadLine();
                            count++;

                        }
                        reader.Close();
                        file.Close();

                        foreach (Grades x in grades)
                        {
                            Console.WriteLine("{0} {1} {2}", x.FName, x.LName, x.Grade);
                        }
                        Console.WriteLine();
                    }
                    catch (Exception w)
                    {
                        Console.WriteLine(w.Message);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR NO SUCH FILE. {0}", e.Message);
                }

            }
            else
            {
                Console.WriteLine("Filename incorrect.");
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