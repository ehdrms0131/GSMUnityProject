using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Enum//한동근 코드 테스트입니덩
    {
        [Flags]
        enum Enumtest
        {
            none=0,
            move=1,
            jump=4,
            attack,
            stop,
            ropeact=8
        }//값 지정 가능
        [Flags]//다중값할당
        protected enum RealEnum
        { none,move,jump,att,rope_act}//차례로 0부터 1씩 추가해줌
        static void Main(string[] args)
        {
            //예제 클론코딩
            Enumtest a = Enumtest.none | Enumtest.move;
            RealEnum b = RealEnum.none | RealEnum.move;
            // & 연산자로 플래그 체크
            if ((a & Enumtest.move) != 0)
            {
                //HasFlag()이용 플래그 체크
                if (a.HasFlag(Enumtest.none))
                {
                    //출력
                    Console.WriteLine(a.ToString());
                }
            }
            if ((b & RealEnum.move) != 0)
            {
                //HasFlag()이용 플래그 체크
                if (a.HasFlag(RealEnum.none))
                {
                    //출력
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}
