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
        int a = DEFAULT_SIZE;
        int[] _data = new int[DEFAULT_SIZE];

        public int Lenght;
        public int Capacify;

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

        

    }
}
