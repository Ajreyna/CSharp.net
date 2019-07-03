using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    class program
    {
        public static Dictionary<string, string> gradeBook = new Dictionary<string, string>();


        public static void Main(string[] args)
        {
            string studentName = "";

            while (addStudent(studentName) == false)
            {

                //  1. Asks for a student name or quit
                Console.WriteLine("Enter a students name or quit to quit");
                studentName = Console.ReadLine();
                if(studentName == "quit")
                {
                    //avgMinMax();
                }
            }

            avgMinMax();



            // 2. If a name is entered the program will 
            //    ask for student grades

        }

        public static bool addStudent(string studentName)
        {
            if (studentName != "")
            {
                if (studentName.ToLower() == "quit")
                {
                    return true;
                }

                else
                {
                    Console.WriteLine("Please enter students grades: ");
                    string input = Console.ReadLine();

                    gradeBook.Add(studentName, input);
                    return false;
                }

            }
            else
            {
                return false;
            }
            

        }
        public static void avgMinMax()
        {
            Console.WriteLine(" ");
            foreach (KeyValuePair<string, string> student in gradeBook)
            {
                string[] gradesString = student.Value.Split(' ');
                int arrayLength = gradesString.Length;
                int[] grades = new int[arrayLength];
                int i = 0;
                int maxValue = 0;
                int minValue = 0;
                double average = 0;
                while (i < gradesString.Length)
                {
                    grades[i] = int.Parse(gradesString[i]);
                    ++i;

                    maxValue = grades.Max();
                    minValue = grades.Min();
                    average = Math.Round(grades.Average(), 2);
                    Console.WriteLine("Student Name {0},  Min Grade {1}, Max Grade {2},  Average Grade: {3}", student.Key, minValue, maxValue, average);
                }

                Console.Read();

            }
        }
    }
}

//{
//{"name1", 90},{"name2", 100}, {"name3", 80}
//};



    //       Console.WriteLine(studentGrades);
    //                // This is for after class logic on how to average the student scores
    //                string sName;
    //         string sGrades;
    //          string[] arrayGrades;
    //int[] iGrades;


    //            foreach (var i in studentGrades.Keys)
    //            {
    //                sName = i;
    //                sGrades = [i]; // it is like "100, 90, 80, 100"
    //                arrayGrades = sGrades.Split(' ');
    //            }

               // iGrades = Array.ConvertAll(arrayGrades, int.Parse);
                //Console.Read();




//            }
//            /////////////////////////////////////////////////////////
//            /// Look up how to get average from integer array ///////
//            ///     This will be the final item to print      ///////
//            /////////////////////////////////////////////////////////

            
//        } 
//    }
//}

    