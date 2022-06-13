// See https://aka.ms/new-console-template for more information
// 파란글자로 뜨는것들은 키워드, 미리 정의되어있는 단어
// 흰색은 식별문자 (참조문자, 명시적  표현)
// 글자색이 어둡다면 (회색 연한 하늘 등,) (참조 없음, 생략 가능 == 암시적 표현)
// 청록색 글자 (클래스 이름)
// 노란색 글자 ( 함수 식별 문자, 함수 이름)
// 하늘색 글자 ( 함수의 파라미터 (매개변수)의 식별문자(이름) )
// 주황색 글자 (문자열 상수)


// 키워드, 특징: namespace 를 사용하기위한 키워드 
// 형식 : using namespace이름
using System;

// namespace 키워드
// 공간을 구분하기위한 키워드
// (내부식별자를 가지고 namespace로 묶인 변수,함수,클래스,인터페이스 등등을 구분함)
namespace Project01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
