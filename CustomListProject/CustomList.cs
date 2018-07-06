using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {

        public CustomList<T> customList;
        private T[] myArr;
        public int arrLength;
        private CustomList<T> c1;
        public T this[int i]
        {
            get { return myArr[i]; }
            set { myArr[i] = value; }
        }
        public CustomList()
        {
            myArr = new T[0];
            arrLength = 0;
        }

        public void Add(T item)
        {
            if (arrLength == 0)
            {
                arrLength++;
                T[] newArry = new T[arrLength];
                newArry[arrLength - 1] = item;
                myArr = newArry;
            }
            else
            {
                arrLength++;
                T[] newArry = new T[arrLength];
                for (int i = 0; i < arrLength - 1; i++)
                {
                    newArry[i] = myArr[i];
                }
                newArry[arrLength - 1] = item;
                myArr = newArry;
            }
        }

        public void Remove(T item)
        {
            T[] newArr = new T[arrLength - 1];

            int i = 0;
            int j = 0;

            while (i < arrLength)
            {
                if (!myArr[i].Equals(item))
                {
                    newArr[j] = myArr[i];
                    j++;
                }
                i++;
            }
            arrLength--;
            myArr = new T[arrLength];
            myArr = newArr;
        }
        public override string ToString()
        {
            string listString = "";
            for (int i = 0; i < arrLength; i++)
            {
                if (i != arrLength - 1)
                {
                    listString += string.Concat(myArr[i].ToString(), ", ");
                }
                else
                {
                    listString += string.Concat(myArr[i].ToString());

                }
            }
            return listString;
        }

        public static CustomList<T> operator +(CustomList<T> l1, CustomList<T> l2)
        {
            for(int i = 0; i < l2.arrLength; i++)
            {
                l1.Add(l2[i]);
            }
            return l1;
        }
        public static CustomList<T> operator -(CustomList<T> l1, CustomList<T> l2)
        {
           CustomList<T> newArr = new CustomList<T>();
           for(int i = 0; i < l1.arrLength; i++)
           {
                for(int j = 0; j < l2.arrLength; j++)
                {
                    if (!l1[i].Equals(l2[j]))
                    {
                        newArr.Add(l1[i]);
                    }
                }
           }
            return newArr;
        }
    }
}
