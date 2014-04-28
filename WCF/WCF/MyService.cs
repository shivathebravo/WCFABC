﻿using System;

namespace WCF
{
    class MyService:IMyService
    {
        public string GetData()
        {
            return "Hello WCF";
        }
        public string  GetMessage(String Name)
        {
            return "Hell WCF" + Name;
        }
        public string GetResult(Student std)
        {
            double Avg=(std.M1+std.M2+std.M3)/3;
            if(Avg<35)
            {
                return "Fali";
            }
            else{
                return "Pass";
            }
             
        }

        public int GetMax(int[] arr)
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            return Max;
        }

    }

    public class Student
    {
        public int Sid { get; set; }
        public string StudentName { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
    }
}
