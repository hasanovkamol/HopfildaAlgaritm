using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfildaAlgaritm
{
    class Hopfilda
    {
        private int[,] Char;
        private double[,] W;
        public Hopfilda()
        {

        }
        private void ClareArray()
        {
            
        }
        /// <summary>
        /// O'ng Dioganal bo'yicha massivni hamma elementini nolga tenglaydi 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private int[,] Dioganal(int[,] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i, i] = 0;
            }
            return array;
        }

        /// Massivni uzunligiga qarab ikki o'lchali massiv xosil qilamiz:
        public double[,] WFunction(int[,] _char)
        {
            int arrayLength = _char.GetLength(1);
            W = new double[arrayLength, arrayLength];
            for (int i = 0; i < _char.GetLength(0); i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    for (int k = 0; k < arrayLength; k++)
                    {
                        W[j, k] += _char[i, j] * _char[i, k];
                    }
                }
            }
            WSumma(ref W);
           // PrintArray(W);
            return W;
        }
        private void WSumma(ref double[,] array)
        {
            int ii = array.GetLength(0);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j) array[i, j] = 0;
                    else
                    array[i, j] = array[i, j] / ii;
                    
                }
            }
        }
        public int[] Sing(int [] t, double[,] W)
        {
            double[] tt = new double[t.Length];
            for (int i = 0; i < W.GetLength(0); i++)
            {
                for (int j = 0; j < W.GetLength(1); j++)
                {
                    tt[i]+= t[i] * W[i, j];
                }
               tt[i]=tt[i] >= 0 ? 1 : -1;
            }
            return t;
        }

        public int FindArray(int[] array,int[,] w)
        {
            int t = -1;
            for (int i = 0; i < w.GetLength(0); i++)
            {
                for (int j = 0; j < w.GetLength(1); j++)
                {
                    if (array[j] == w[i, j])
                    {
                        t = i+1;
                    }
                    else
                    {
                        t = -1;
                        break;
                    }
                }
            }
            return t;
        }
       
        private void PrintArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
       
    }
}
