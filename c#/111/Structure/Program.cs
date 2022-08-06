using System;


public struct Stats
{
    public int STR;
    public int DEX;
    public int INT;
    public int LUK;

    public Stats(int STR, int DEX, int INT, int LUK)
    {
        this.STR = STR;
        this.DEX = DEX;
        this.INT = INT;
        this.LUK = LUK;
    }
    public int Score()
    {
        return STR + DEX + INT + LUK;
    }
}

namespace Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //구조체 생성자는 멤버필드 초기화에 사용할 뿐 힙 영역에 할당하거나 참조를 반환하지 않는다
            Stats stats = new Stats(1, 2, 3, 4);


            Console.WriteLine(stats.Score());
        }
    }


    public class Player
    {
        public Stats stats;
        public int HP;
        public int MP;


        public void Attack()
        {
            Console.WriteLine("공격");
        }
    }
}
