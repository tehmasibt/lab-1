// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");


#region task-1
//int[] number = { 12, 10, 2, 18, 30 };
//int sum = 0;
//for (int i = 0; i < number.Length; i++)
//{
//    sum += number[i];
//}
//Console.WriteLine(sum);
#endregion
#region faktorial
//int a = 5;
//int b = 1;
//for (int i = 1; i <= a; i++)
//{
//    b*=i;
//}
//Console.WriteLine(b);
#endregion
#region 5-lerin sayi
int[] num = { 5, 8, 2, 7, 23, 5, 3, 5 };
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i]==5)
    {
        count++;
    }
}
Console.WriteLine(count);
#endregion


