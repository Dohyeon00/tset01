using System;


namespace Example02_
{
    internal class Program
    {

        static int[,] map = new int[5, 5]
        {
            {0, 0, 0 ,0, 1 },
            {0, 1, 1, 1, 1 },
            {0, 0, 0, 1, 1 },
            {1, 1, 0, 0, 0 },
            {0, 1, 1, 0, 0 },
        };

        static void Main(string[] args)
        {
            Player player = new Player();
            player.x = 3;
            player.y = 0;
            player.MoveLeft(map);
        }
    }

    class Player
    {
        public int x, y;

        public void MoveLeft(int[,] map)
        {
            if (x - 1 < 0)
            {
                Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. (맵의 경계)");
            }
            else if (map[y, x - 1] == 0)
            {
                x--;
                Console.WriteLine($"플레이어가 왼쪽으로 한칸이동, 현재위치 {x}, {y}");
            }
            else if (map[y, x - 1] == 1)
            {
                Console.WriteLine($"플레이어를 왼쪽으로 이동시킬 수 없습니다. (벽)")
                
            }
        }
    }
}