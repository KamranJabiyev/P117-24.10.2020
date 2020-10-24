using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public static class Extension
    {
        public static int[] SameValues(this int[] arr,int[] arr1)
        {
            int[] result = new int[0];
            foreach (int item1 in arr)
            {
                foreach (int item2 in arr1)
                {
                    if (item1 == item2)
                    {
                        //Console.WriteLine("Before resize: "+result.Length);
                        Array.Resize(ref result, result.Length + 1);
                        //Console.WriteLine("After resize: " + result.Length);
                        result[result.Length - 1] = item1;
                    }
                }
            }

            return result;
        }
    }
}
