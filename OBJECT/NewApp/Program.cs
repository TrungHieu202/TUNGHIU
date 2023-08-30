// See https://aka.ms/new-console-template for more information
public class Program
{
    private static void Main (string[] args)
 {
Console.WriteLine("Nhap 2 so can so sanh: ");
int a,b;
System.Console.WriteLine("a = ");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("b = ");
b = Convert.ToInt32(Console.ReadLine());
if (a == b){
    System.Console.WriteLine("Hai so bang nhau ");   
}
if (a < b){
    System.Console.WriteLine("so a nho hon so b");
}
if (a > b){
    System.Console.WriteLine("so a lon hon so b");
}
 }   
}
