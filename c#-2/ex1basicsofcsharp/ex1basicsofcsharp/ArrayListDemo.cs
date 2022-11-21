using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal class ArrayListDemo
    {
        public static void demo1()
        {
            Console.WriteLine("ARRAYLIST");
            Console.WriteLine("*****DEMO1*****");
            // adding elements using ArrayList.Add() method
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };
            
            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

            Console.WriteLine("ArrayList 2 Elements");

            for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);
            //create array in two ways
        }
        public static void demo2()
        {
            Console.WriteLine("*****DEMO2*****");
            var arlist1 = new ArrayList();

            var arlist2 = new ArrayList()
                            {
                                1, "Bill", " ", true, 4.5, null
                            };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 

            Console.WriteLine("ArrayList Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);
        }
        public static void demo3()
        {
            var arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            //Access individual item using indexer
            //int firstElement = (int)arlist[0]; //returns 1
            Console.WriteLine("*****DEMO3*****");
            Console.WriteLine("Acces individual item using indexer");
            //Console.WriteLine(firstElement);
            //string secondElement = (string)arlist[1]; //returns "Bill"
            //Console.WriteLine(secondElement);
            //int secondElement = (int) arlist[1]; //Error: cannot cover string to int

            //using var keyword without explicit casting
            var first = arlist[0]; //returns 1
            var second = arlist[1];
            Console.WriteLine("using var keyword without explicit casting");
            Console.WriteLine(first);
            Console.WriteLine(second);
                                    //var fifthElement = arlist[5]; //Error: Index out of range

            //update elements
            arlist[0] = "Steve";
            arlist[1] = 100;
            Console.WriteLine("Update Elements");
            foreach(var item in arlist)
            {
                Console.WriteLine(item + ", ");
            }
            //arlist[5] = 500; //Error: Index out of range
        }
        public static void demo4()
        {
            Console.WriteLine("*****DEMO4*****");
            Console.WriteLine("For Loop");
            var arrlist = new ArrayList()
            {
                "ilakkiya",1,20.0f
            };
            for(var i = 0; i < arrlist.Count; i++)
            {
                Console.WriteLine(arrlist[i]);
            }
            Console.WriteLine("ForEach");
            foreach(var i in arrlist)
            {
                Console.WriteLine(i);
            }
        }
        public static void demo5()
        {
            Console.WriteLine("*****DEMO5*****");
            Console.WriteLine("INSERT");
            ArrayList arlist = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f
                };

            arlist.Insert(1, "Second Item");

            foreach (var val in arlist)
                Console.WriteLine(val);
        }
        public static void demo6()
        {
            Console.WriteLine("*****DEMO6*****");
            Console.WriteLine("INSERTRANGE");
            ArrayList arlist1 = new ArrayList()
                {
                    100, 200, 600
                };

            ArrayList arlist2 = new ArrayList()
                {
                    300, 400, 500
                };
            arlist1.InsertRange(2, arlist2);

            foreach (var item in arlist1)
                Console.Write(item + ", ");
        }
        public static void demo7()
        {
            Console.WriteLine("*****DEMO7*****");
            Console.WriteLine("Remove");
            ArrayList arList = new ArrayList()
                {
                    1,null,"Bill",300," ",4.5f,300
                };

            arList.Remove(null); //Removes first occurance of null
            Console.WriteLine("Null Removed: ");
            foreach(var item in arList)
            {
                Console.WriteLine(item);
            }
            arList.RemoveAt(4); //Removes element at index 4
            Console.WriteLine("RemoveAt: ");
            foreach (var item in arList)
            {
                Console.WriteLine(item);
            }
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("RemoveRange");

            foreach (var item in arList)
                Console.WriteLine(item);
        }
        public static void demo8()
        {
            Console.WriteLine("*****DEMO8*****");
            Console.WriteLine("Check Element");
            ArrayList arList = new ArrayList()
                {
                    1,"Bill",300,4.5f,300
                };

            Console.WriteLine(arList.Contains(300)); // true
            Console.WriteLine(arList.Contains("Bill")); // true
            Console.WriteLine(arList.Contains(10)); // false
            Console.WriteLine(arList.Contains("Steve")); // false
        }
    }
}
