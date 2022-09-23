using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);
        Console.WriteLine(intList[0]);
        Console.ReadLine();


        //int[] numbArray = new int[5];
        //numbArray[0] = 5;
        //numbArray[1] = 2;
        //numbArray[2] = 10;
        //numbArray[3] = 200;
        //numbArray[4] = 5000;
        
        //int[] numbArray1=new int[] { 5, 210, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();
    }
    }

