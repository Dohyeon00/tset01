using System;
using System.Collections.Generic;

//Generic 일반화
// 다양한 자료형에 대해서 유동적으로 갖다쓸수 있도록 만드는 형태
// 1+1+1+1+1
// n+n+n+n+n 이렇게 만들어두면 값만 넣어서 언제든 이 식을 쓸 수 있다


namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            List<int> list_int = new List<int>();
            List<float> list_float = new List<float>();
            List<List<int>> list_list_int = new List<List<int>>();

            //추가
            list_int.Add(0);
            list_float.Add(1.0f);
            list_list_int.Add(list_int);
            list_list_int.Add(new List<int>());
            
            //삭제
            list_int.Remove(0);
            list_list_int.RemoveAt(0);

            //검색
            //list_list_int.Find(x => x == 0);
            list_int.Contains(0);


            //LinkedList    
            LinkedList<int> list = new LinkedList<int>();
            list.Contains(0);

            //Dictionary
        }
    }
}
