using System;

// 함수: 특정 연산에 대한 기능
//method :  함수 중에서 객체를 통해서 호출되는 함수 
namespace methods
{
    internal class program
    {

        static int b = 3;
        //program 클래스의 멤버 함수
        static void Main(string[] args)
        {
            PrintHelloWorld();
            PrintNum(3); // 3
            PrintSumResult(1, 2); //1 + 2 = 3


            //지역변수 : 함수안에서 선언된 변수
            //지역변수가 할당되는 공간은 어떤 값이 들어있는지 알 수 없으므로
            //초기화를 해주어야한다
            int a = 2;
            int b = 3;

            Console.WriteLine(Sum(a, b)); // 5


            float a1 = 5.25f;
            float b2 = 4.24f;

            Console.WriteLine(Son(a1, b2));

            Console.WriteLine(5); // 5
            
        }

        //함수의 형태
        //매개변수 자료형 매개변수 이름
        // 반환 : 제어권을 넘겨준다
        // void 반환시에 특별한 값을 넘기지않는다
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void PrintNum(int num)
        {
            Console.WriteLine(num);
        }


        static void PrintSumResult(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int Sum (int a, int b)
        {
            return a + b;
        }
        
        static float Son(float a1, float b2)
        {
            return a1 - b2;
        }
    }
}