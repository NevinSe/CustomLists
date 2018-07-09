using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        public CustomList<T> customList;
        private T[] myArr { get; set; }
        public int Count { get; set; }
        public T this[int i]
        {
            get { return myArr[i]; }
            set { myArr[i] = value; }
        }
        public CustomList()
        {
            Count = 0;
            myArr = new T[Count];
           
        }

        public void Add(T item)
        {
            if (Count == 0)
            {
                Count++;
                T[] newArry = new T[Count];
                newArry[Count - 1] = item;
                myArr = newArry;
            }
            else
            {
                Count++;
                T[] newArry = new T[Count];
                for (int i = 0; i < Count - 1; i++)
                {
                    newArry[i] = myArr[i];
                }
                newArry[Count - 1] = item;
                myArr = newArry;
            }
        }

        public void Remove(T item)
        {
            T[] newArr = new T[Count - 1];

            int i = 0;
            int j = 0;

            while (i < Count)
            {
                if (!myArr[i].Equals(item))
                {
                    newArr[j] = myArr[i];
                    j++;
                }
                i++;
            }
            Count--;
            myArr = new T[Count];
            myArr = newArr;
        }
        public override string ToString()
        {
            string listString = "";
            for (int i = 0; i < Count; i++)
            {
                if (i != Count - 1)
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
            for(int i = 0; i < l2.Count; i++)
            {
                l1.Add(l2[i]);
            }
            return l1;
        }
        public static CustomList<T> operator -(CustomList<T> l1, CustomList<T> l2)
        {
           CustomList<T> newArr = new CustomList<T>();
           for(int i = 0; i < l1.Count; i++)
           {
                for(int j = 0; j < l2.Count; j++)
                {
                    if (!l1[i].Equals(l2[j]))
                    {
                        newArr.Add(l1[i]);
                    }
                }
           }
            return newArr;
        }

        public CustomList<T> Zipper(CustomList<T> l1)
        {
            CustomList<T> newArry = new CustomList<T>();
            int i = 0;
            if (Count > l1.Count)
            {
                while (i < Count)
                {
                    if (i < l1.Count)
                    {
                        newArry.Add(myArr[i]);
                        newArry.Add(l1[i]);
                    }
                    else
                    {
                        newArry.Add(myArr[i]);
                    }
                    i++;
                }
            }
            else
            {
                while (i < l1.Count)
                {
                    if (i < Count)
                    {
                        newArry.Add(myArr[i]);
                        newArry.Add(l1[i]);
                    }
                    else
                    {
                        newArry.Add(l1[i]);
                    }
                    i++;
                }
            }
           
            return newArry;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myArr[i];
            }
        }
    }
}
