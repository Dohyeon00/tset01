using System;

// 휴먼 클래스를 만들고
// 정수형 나이, 실수형 키, 문자형 성별문자를 멤머변수로 가지고
// 나이를 콘솔창에 출력하는 함수를 멤버 함수로 가진다
// 휴ㅜ먼 객체 2개 생성
// 휴먼 1의 나이 100 키 200 성별 남
// 휴먼 2의 나이 50 키 150 성별 여


// 접근 제한자
// private 외부 클래스 / 객체에서 접근할 수 없도록 제한
// public 외부클래스 / 객체에서 접근할 수 있도록 제한해제
// internal : 동일 프로젝트에서 public 처럼 동작함
// protected : 자식만 접근가능하도록 제한

// class 의 멤버들은 접근제한자를 명시하지 않으면 기본적으로 프라이빗(private)
// 접근 제한자를 정확하게 명시해야하는 이유는 제 3자가 봤을때 
// 접근하면 안되는 멤버에 접근하는 등의 사고로인해 코드를 잘못 작성할 가능성을 없에기 위함

namespace InstantiationExample
{

    internal class Example
    {
        static void Main(string[] args)
        {

            Human1 human01 = new Human1();
            Human2 human02 = new Human2();


            Console.WriteLine("------------------");
            Console.Write("-휴먼 1의 정보\n");
            Console.WriteLine("");
            Console.Write("-나이 : ");
            Console.Write(human01.age);
            Console.WriteLine("");
            Console.Write("\n-키 : ");
            Console.Write(human01.height);
            Console.WriteLine("");
            Console.Write("\n-성별 : ");
            Console.Write(human01.genderchar);
            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.Write("-휴먼 2의 정보\n");
            Console.WriteLine("");
            Console.Write("-나이 : ");
            Console.Write(human02.age);
            Console.WriteLine("");
            Console.Write("\n-키 : ");
            Console.Write(human02.height);
            Console.WriteLine("");
            Console.Write("\n-성별 : ");
            Console.Write(human02.genderchar);
            Console.WriteLine("");
            Console.WriteLine("------------------");


        }
    }





    class Human1
    {
        public int age;
        public float height;
        public string genderchar;



        public Human1()
        {
            age = 100;
            height = 200f;
            genderchar = "남";
        }

    }

    class Human2
    {
        public int age;
        public float height;
        public string genderchar;

        public Human2()

        {
            age = 50;
            height = 150f;
            genderchar = "여";
        }



    }





}