﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class program
    {
        public static void Main(string[] args)
        {


            //  1. Asks for a student name or qu
            Console.WriteLine("Enter a students name or quit to quit");
            string choice = Console.ReadLine();


            // 2. If a name is entered the program will 
            //    ask for student grades
            Console.WriteLine("Enter a grade for student");
            string grades = Convert.ToString(Console.ReadLine());

            //  while (choice.ToLower() != "quit")
            //{


            IDictionary<int, string> studentGrades = new Dictionary<int, string>();

            { studentGrades.Add(new KeyValuePair<int, string>(1, "one"));

                studentGrades.Add(new KeyValuePair<int, string>(2, "two"));
                studentGrades.Add(new KeyValuePair<int, string>(3, "three"));

            }
                             //{
                //{"name1", 90},{"name2", 100}, {"name3", 80}
                //};



//                Console.WriteLine(studentGrades);
//                // This is for after class logic on how to average the student scores
//                string sName;
//                string sGrades;
//                string[] arrayGrades;
//                int[] iGrades;


//                foreach (var i in studentGrades.Keys)
//                {
//                    sName = i;
//                    sGrades = [i]; // it is like "100, 90, 80, 100"
//                    arrayGrades = sGrades.Split(' ');
//                }

//               // iGrades = Array.ConvertAll(arrayGrades, int.Parse);
//                Console.Read();




//            }
//            /////////////////////////////////////////////////////////
//            /// Look up how to get average from integer array ///////
//            ///     This will be the final item to print      ///////
//            /////////////////////////////////////////////////////////

            
//        } 
//    }
//}

