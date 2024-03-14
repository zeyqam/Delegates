using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelegatePractice
    {
        // delegate referans taypdir
        // hansi method ucun yaradiramsa delegetin return taypi ona uygun olmalidi,ve method bir parametr qebul edirse delegetde bir paramater qebul etmelidir
        //public delegate bool ChekNums(int a);
        //public delegate void ChangeStr(string str);
        public delegate int CalculateLength(string str,int num);
        //public bool CheckOdd(int num)
        //{
        //    return num % 2 != 0;
        //}
        //public bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}
        public void StrToUpper(string str)
        {
            str = str.ToUpper();
            Console.WriteLine(str);
        }
        public void StrToLower(string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }

        public int GetLength(string str, int num)
        {
            return str.Length+num;
        }
        public bool CheckNums(int num1, int num2,int num3)
        {
            return num1>5&num2>5&& num3>5;
        }

        public void Execute()
        {
            //GetLengthOfStr("salam", GetLength);
            // ShowText("salam",StrToUpper);
            // ShowText("Sagol", StrToLower);
            //Action<string> del1= StrToUpper;
            // Action<string> del2= StrToLower;
            // del1("Sagol");
            // del2("salam");




            //    List<int> list = new List<int> { 1,2,3,4,5};
            //    //list.Where(m => m >100)
            //    SumOfNumsByCondition(list,m=>m%2!=0);
            //    SumOfNumsByCondition(list, m=>m%2==0);
            //Func<string, int, int> func = GetLength;
            //var t = func("hello", 100);
            //    Console.WriteLine(t);
            SumOfNumsByCondition(10, 11, 12, CheckNums);


        }
        public void SumOfNumsByCondition(int num1,int num2,int num3,Func<int,int,int,bool> expression)
        {
            if(expression(num1,num2,num3))
            {
                Console.WriteLine(num1 + num2 + num3);
            }
        }

        //public void GetLengthOfStr(string str,Func<string,int,int> func)
        //{
        //    int count = func(str,10);
        //    Console.WriteLine(count);
        //}
        
        //public void ShowText(string text,Action<string> func)
        //{
        //    func(text);
        //}


        //return typi  boolan olan ve bir parametr qebul eden butun metodlari predicate  qebul metodlarin atmaq olar
        //public void SumOfNumsByCondition(List<int> nums,Predicate<int> func)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
                
        //    }
        //    Console.WriteLine(sum);
        //}
        //public void SumOfEvenNums(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item % 2 == 0)
        //        {
        //            sum += item;
        //        }

        //    }
        //    Console.WriteLine(sum);
        //}
        //public void SumOfGreaterSevenNums(List<int> nums)
        //{
        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item >7)
        //        {
        //            sum += item;
        //        }

        //    }
        //    Console.WriteLine(sum);
        //}


    }
}
