using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[2] { 12, 15 };
            matrix[2] = new int[3] { 16, 17 ,18};
            int element = 0;
            element = matrix[0][2];
            Console.WriteLine("Stored Values of Array");
            for(int i = 0;i<matrix.Length;i++)
            {
                Console.WriteLine("Internal Array Elements");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            dynamic MyObject = new dynamic[2][];
            MyObject[0] = new dynamic[3] { 12, "Sam", 86.99 };
            MyObject[1] = new dynamic[4] {'A',true,"Sam",DateTime.Now};
            for(int i=0;i<MyObject.Length;i++)
            {
                for(int j = 0; j < MyObject[i].Length;j++)
                {
                    Console.WriteLine(MyObject[i][j]);
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
