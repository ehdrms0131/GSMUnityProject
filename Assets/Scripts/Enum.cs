using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Enum
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
        }
        static void Main(string[] args)
        {
            Enumtest a = Enumtest.none | Enumtest.move;
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
        }
    }
}
