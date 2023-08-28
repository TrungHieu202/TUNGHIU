// See https://aka.ms/new-console-template for more information
public class Program
{
    private static void Main (string[] args)
 {
Console.WriteLine("Nhap 2 so can tinh: ");
int a,b;
System.Console.WriteLine("a = ");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("b = ");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("hieu cua hai so la: {0} - {1} = {2}",a,b,a-b);
System.Console.WriteLine("tich cua hai so la: {0} * {1} = {2}",a,b,a*b);
System.Console.WriteLine("thuong cua hai so la: {0} / {1} = {2}",a,b,a/b);
System.Console.WriteLine("so du cua hai so la: {0} % {1} = {2}",a,b,( a - b * (a / b)));

 }   
}
