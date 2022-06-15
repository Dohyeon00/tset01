using System;


namespace ClassObjectInstance // note: actual namespace depends on the project name.
{
    internal class program
    {
        static void main(string[] args)
        {
            // 값형식, 참조형식
            // 값형식 값을 직접 읽고 쓰는 형태의 함수
            // 참조형식 주소를 읽고 주소의 위치에 값을 쓰는 형식

            // int 정수 타입
            // a 정수형 변수
            int a = 0;

            // Human 클래스  Human1 객체
            // new 동적할당하는 키워드
            Human human1 = new Human();
        }
    }


    class Human
    {
        public static int age = 1;
        public float height;
        public bool isresting;
        public char genderchar;
        public  string name;
        public double wieght;

        // 생성자
        public Human()
        {
            return;
        }

    }
}