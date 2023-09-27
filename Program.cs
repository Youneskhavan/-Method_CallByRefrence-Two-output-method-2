using Call_by_refrence;
using System;




int Sum;
int Avg;
Console.WriteLine("Enter the grade of lesson 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the grade of lesson 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the grade of lesson 3");
int c = Convert.ToInt32(Console.ReadLine()); 

Teacher.AvgSum(a,b,c,out Sum, out Avg );

Console.WriteLine("Sum : {0}\t Avg : {1} ",Sum,Avg);
