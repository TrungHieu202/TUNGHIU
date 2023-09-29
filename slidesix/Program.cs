using slidesix.Models;
public class Program
{
    private static void Main(string[] args)
    {
    Student[]stdArray =new Student[2];
    for(int i = 0; i < stdArray.Length; i++ )
    {
        Student std = new Student ();
        System.Console.WriteLine("nhap phan tu thu " + i);
    std.EnterData();
    stdArray[i] = std;
    }
    }
}



