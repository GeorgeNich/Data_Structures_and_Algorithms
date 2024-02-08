using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class InsertionSort : ISorter
    {



        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            for (int i = 1; i< sequence.Length; i++)
            {
                int j = i;
                while ((j > 0) && (comparer.Compare(sequence[j-1], sequence[j])) > 0)
                {
                    K temp = sequence[j];
                    sequence[j] = sequence[j - 1];
                    sequence[j - 1] = temp;
                    
                    
                    j = j - 1;
                }
            }
        }

    }
}
