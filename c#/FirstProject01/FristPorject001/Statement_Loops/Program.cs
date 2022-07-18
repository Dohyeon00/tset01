using System;

namespace Statement_Loops
{

    // 반복문의 종류
    // while, do while,for, forcach
    // while 조건이 참이면 해당 내용 반복수행
    // do while 일반 한번 수행하고 조건이 참이면 해당내용 반복 수행
    // for 조건이 참이면 해당내용 반복수행하며 반복수행이 끝날때 마다 특정 연산이 가능
    // foreach cillection 또는 배열의 모든 요소에 접근해서 반복수행













    internal class Program
    {
        static void Main(string[] args)
        {

            //while (true)
            //{
            //    Console.WriteLine(1);


            //}

            //do
            //{
            //    Console.WriteLine(1);
            //} while (true);


            int[] tmpArr = new int[5];
            

            for (int i = 0; i < tmpArr.Length; i++)
            {
                Console.WriteLine(tmpArr[i]);
            }


            // 다차원 배열
            int[,] mat2D = new int[3, 5]
            {
                { 1, 2, 3, 4, 5},
                { 4, 5, 6, 7, 8},
                { 4, 5, 6, 0, 4},

                
            };

            for (int i = 0; i< mat2D.GetLongLength(0); i++)
            {
                for (int j = 0; j < mat2D.GetLength(1); j++)
                {
                    Console.Write(mat2D[i, j] + ", ");
                }
                Console.WriteLine();
            }


            //// collection 내의 모든 요소들에 접근
            //// 접근시 해당요소는 var item 지역변수에 대입
            //foreach (var item in collection)
            //{
            //}

            int[][] arr2D = new int[5][];
            for (int i = 0; i < arr2D.Length; i++)
            {
                arr2D[i] = new int[3];
            }
        

            foreach (int item in tmpArr)
            {
                Console.WriteLine(item);
            }


        }
    }

}
