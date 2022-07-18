using System;

namespace Array
{
    internal class Program

    // 배열
    // 형태 : 자료형[]
    // 자료형이 정적으로 나열되어있는 형태
    // 한번 크기를 정하면 일반적으로 바꿀 수 없다.
    {
        static void Main(string[] args)
        {
            int[] arrint = new int[3];
            int[] arrint2 = { 4, 5, 6 };

            // 배열의 인덱스 접근
            // 배열 변수 이름[인데스숫자]
            // 배열의 가장 첫번째 주소로부터
            // 인덱스숫자 * 배열의 요소의 자료형 크기만큼 뒤에 있는 배열 요소에 접근

            arrint[0] = 1;
            arrint[1] = 2;
            arrint[2] = 3;

            Console.WriteLine(arrint[0]);
            Console.WriteLine(arrint[1]);
            Console.WriteLine(arrint[2]);
            Console.WriteLine();
            Console.WriteLine(arrint2[0]);
            Console.WriteLine(arrint2[1]);
            Console.WriteLine(arrint2[2]);



            string[] arrSring = new string[3];
            arrSring[0] = "김아무개";
            arrSring[1] = "이아무개";
            arrSring[2] = "박아무개";


            char[] arrChar = { 'a', 'b', 'c' };
            String tmpString = new String(arrChar);
            Console.WriteLine(tmpString);
            string temString2 = "Luke";
            Console.WriteLine(temString2[0]);

        }

    }
}
