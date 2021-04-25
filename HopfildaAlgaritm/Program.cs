using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfildaAlgaritm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 9];
            array[0, 0] = 1;
            array[0, 1] = 1;
            array[0, 2] = 1;
            array[0, 3] = 1;
            array[0, 4] = -1;
            array[0, 5] = 1;
            array[0, 6] = 1;
            array[0, 7] = -1;
            array[0, 8] = 1;

            array[1, 0] = 1;
            array[1, 1] = 1;
            array[1, 2] = 1;
            array[1, 3] = 1;
            array[1, 4] = -1;
            array[1, 5] = -1;
            array[1, 6] = 1;
            array[1, 7] = -1;
            array[1, 8] = -1;

            array[2, 0] = 1;
            array[2, 1] = -1;
            array[2, 2] = -1;
            array[2, 3] = 1;
            array[2, 4] = -1;
            array[2, 5] = -1;
            array[2, 6] = 1;
            array[2, 7] = 1;
            array[2, 8] = 1;

            Hopfilda hopfilda = new Hopfilda();
            
            int[] tt = new int[9];
            tt[0] = 1;
            tt[1] = -1;
            tt[2] = -1;
            tt[3] = 1;
            tt[4] = -1;
            tt[5] = -1;
            tt[6] = 1;
            tt[7] = 1;
            tt[8] = 1;
            tt=hopfilda.Sing(tt, hopfilda.WFunction(array));
            Console.WriteLine(hopfilda.FindArray(tt, array));

            Console.ReadKey();
        }
    }
}
