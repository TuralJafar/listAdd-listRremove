using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class MyList<T>
        where T : class
    {
        T[] myArray;
        public int Count { get; set; }
        public void Add(T item)
        {

            if (Count == 0)
            {
                myArray = new T[4];
                myArray[Count++] = item;
            }
            else if(Count >=myArray.Length) 
            {
                Array.Resize(ref myArray, myArray.Length*2);
                myArray[Count++]=item;

            }
            else
            {
                myArray[Count++]=item;
            }
        }
        public void Remove(T item)
        {   int index=IndexOf(item);
            if (index! == -1)
            {
                T[] newArray = new T[myArray.Length - 1];
                int j = 0;
                for (int i = 0; i < myArray.Length;)
                {
                    if (i != index)
                    {
                        newArray[j++] = myArray[i];
                    }
                }
                myArray= newArray;
                Count--;
            }
          
        }
        public int IndexOf(T item)
        {
          for(int i=0; i<myArray.Length; i++)
            {
                if (myArray[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;

        }
        
    }
}
