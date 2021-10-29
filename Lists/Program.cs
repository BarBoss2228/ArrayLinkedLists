using System;
using ArrayLists;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            AL arr = new AL(new int[] { 1,2,3,4,5,6,7,8});
            /*arr.RemoveFirst();
            arr.PrintArray();
            arr.RemoveAt(3);
            arr.PrintArray();*/
            //arr.RemoveFirstMultiple(3);
            arr.RemoveAtMultiple(2, 5);
            arr.PrintArray();

        }
    }
}
