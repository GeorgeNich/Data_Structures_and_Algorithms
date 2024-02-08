using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class BubbleSort : ISorter
    {


        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            if (comparer == null) comparer = Comparer<K>.Default;
            for (int i = 1; i < sequence.Length; i++)
            {
                int swaps = 0;
                for (int j = 0; j < sequence.Length-1; j++)
                {
                    if (comparer.Compare(sequence[j] ,sequence[j+1]) > 0)
                    {

                        K temp = sequence[j];
                        sequence[j] = sequence[j+1];
                        sequence[j+1] = temp;

                        swaps = swaps + 1;
                    }

                }
                if(swaps == 0)
                break;
            }


        }

        //public void swap<K>(K A, K B) where K : IComparable<K>
        //{
        //    K temp = A;
        //    A = B;
        //    B = temp;
        //}



    }
}
