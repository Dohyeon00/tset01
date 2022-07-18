using System;

//// **객체선정 :** 

//오크(orc)

//* *추상화 :**

// 오크는

// [이름, 키, 몸무게, 나이, 성별문자, 쉬고있는지 ? ]에 대한 특징과

//[휘두르기, 점프하기] 의 기능을 가지고 있다.

namespace Example01_ClassObjectinstance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Orc1 orc1 = new Orc1();
            Orc2 orc2 = new Orc2();

           

        }
    }




    class Orc1
    {
        public string name = "상급오크";
        public float height = 240.2f;
        public float weight = 200;
        public int age = 140;
        public string genderChar = "남";
        public bool isResting = false;

        public void Smash()
        {
            Console.WriteLine(name + " (이)가 휘둘렀다.");
        }

        public void Jump()
        {
            Console.WriteLine(name + "(이)가 점프했다.");
        }



    }

    class Orc2
    {
        public string name = "하급오크";
        public float height = 140.4f;
        public float weight = 120f;
        public int age = 60;
        public string genderChar = "여";
        public bool isResting = true;

        public void Smash()
        {
            Console.WriteLine(name + " (이)가 휘둘렀다.");
        }

        public void Jump()
        {
            Console.WriteLine(name + "(이)가 점프했다.");
        }

        public void JumpANdSmash()
        {

        }

    }

}
