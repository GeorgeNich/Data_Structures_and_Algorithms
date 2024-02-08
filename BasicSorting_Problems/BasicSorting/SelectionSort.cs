using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class SelectionSort : ISorter
    {

        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < sequence.Length; j++)
                {

                    if (comparer.Compare(sequence[j], sequence[min]) < 0)
                    {
                        min = j;
                    }

                }
                if (min != i)
                { 
                    // then swap(A[i], A[min]);
                    K temp = sequence[i];
                    sequence[i] = sequence[min];
                    sequence[min] = temp;
                }

            }

        }

    }
}
