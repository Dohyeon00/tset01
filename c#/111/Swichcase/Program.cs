using System;


// enum 열거형 사용자정의자료형


public enum state
{
    Run = 10,
    Walk,
    Die,
    Attack,
}


public enum WalkingToastState
{
    PutFryPanOnInduction,
    InductionOn,
    PutButter,
    PutBread,
    ReverseBread,
    InductionOff,
    TranslatetoastDish,
}

public enum StateFlags
{
    Idle,
    Run,
    Walk,
    Jump,
    Die,
    Attack,
    Hart,

}


namespace Switchcase
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int stateNum = 0;

            switch (stateNum)
            {
                case 0:
                    Console.WriteLine("0 입니다.");
                    break;
                case 1:
                    Console.WriteLine("1 입니다.");
                    break;

                default:
                    break;
            }

            state state = state.Run;

            switch (state)
            {
                case state.Run:
                    Console.WriteLine("문도 뛴다");
                    break;
                case state.Walk:
                    Console.WriteLine("문도 걷는다.");
                    break;
                case state.Die:
                    Console.WriteLine("문도 죽는다.");
                    break;
                case state.Attack:
                    Console.WriteLine("문도 때린다.");
                    break;
                default:
                    break;
            }
            WalkingToastState walkingToastState = WalkingToastState.PutFryPanOnInduction;
            bool tosatcomplete = false;
            while (tosatcomplete == false)
            {
                switch (walkingToastState)
                {
                    case WalkingToastState.PutFryPanOnInduction:
                        Console.WriteLine("인덕션 올리기");
                        walkingToastState++;
                        break;
                    case WalkingToastState.InductionOn:
                        Console.WriteLine("인덕션 켜기");
                        walkingToastState++;
                        break;
                    case WalkingToastState.PutButter:
                        Console.WriteLine("버터 넣기");
                        walkingToastState++;
                        break;
                    case WalkingToastState.PutBread:
                        Console.WriteLine("빵 넣기");
                        walkingToastState++;
                        break;
                    case WalkingToastState.ReverseBread:
                        Console.WriteLine("빵 뒤집기");
                        walkingToastState++;
                        break;
                    case WalkingToastState.InductionOff:
                        Console.WriteLine("인덕션 끄기");
                        walkingToastState++;
                        break;
                    case WalkingToastState.TranslatetoastDish:
                        Console.WriteLine("먹방 하기");
                        tosatcomplete = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
