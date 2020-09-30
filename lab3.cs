using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
public class Program
{
public static void Main(string[] args)
{

Console.Write(" Сумма = ");
int sum = Convert.ToInt32(Console.ReadLine());
Console.Write(" Процент = ");
int percent = Convert.ToInt32(Console.ReadLine());
Console.Write(" Срок = ");
int srok = Convert.ToInt32(Console.ReadLine());
double c= Math.Pow( (((double)percent/100)+1),srok);
double a= sum*(double)c;
Console.WriteLine(a);

}
}
}