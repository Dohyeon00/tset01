using System;


namespace ClassObjectInstance // note: actual namespace depends on the project name.
{
    internal class program
    {
        static void Main(string[] args)
        {
            // 값형식, 참조형식
            // 값형식 값을 직접 읽고 쓰는 형태의 함수 , 스택영역에 할당
            // 참조형식 주소를 읽고 주소의 위치에 값을 쓰는 형식

            // int 정수 타입
            // a 정수형 변수
            int a = 0;


            // Human 클래스  Human1 객체
            // new 동적할당하는 키워드
            Human human1 = new Human();
            // 객체화 클래스로 객체를 생성하는 과정
            // 인스턴스화 객체에 실제 데이터를 초기화해서 사용하게되는 과정

            Console.WriteLine(human1.wieght);
            Console.WriteLine(human1.height);
            human1.height = 200;

            // .점연산자 : 멤버에 접근할때 쓰는 연산자
        }
    }


    class Human
    {
        public static int age = 6;
        public float height;
        public bool isresting;
        public char genderchar;
        public string name;
        public double wieght;

        // 생성자
        public Human()
        {

            height = 100;
            wieght = 20;

        }


        // 소멸자 (해당객체를 만들때 할당했었던 메모리 해제)

        ~Human()
        {

        }


    }

 





}