using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03_DynamicArray
{
    internal class DynamicArray
    {


        
        const int DEFAULT_SIZE = 1; // const 키워드 : 해당 변수를 상수형태로 사용하겠다는 키워드

        int[] _data = new int[DEFAULT_SIZE];

        public int Lenght;


        //프로퍼티 필드의 값을 쓰거나 읽을떄 get 함수나 set함수를 요이하게 만들어서 접근할 수 있는 get
        //접근자와set 접근자를 구별할 수 있는 함수
        public int Capacify
        {
            get { return _data.Length; }
            
        }




        public void Add(int item)
        {

           if(Lenght >= Capacify)
           {

                int[] tmp = new int[Capacify * 2];

                for (int i = 0; i < Lenght; i++)
                {
                    tmp[i] = _data[i];
                }
                _data = tmp;
           }
           _data[Lenght] = item;
           Lenght++;
        }

        
        public void Remove(int item)
        {
            bool isFound = false;
            for (int i = 0; i < Length; i++)
            {
                if(_data[i] == item)
                {
                    isFound = true;
                    RemoveAt(i);
                    break;
                }
            }
            return isFound; 
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < Lenght - 1; i++)
            {
                _data[i] = _data[i + 1];
            }
            _data[Lenght - 1] = 0;
            Lenght--;
        }
    }
}
