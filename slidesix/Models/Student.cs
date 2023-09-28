using System.Dynamic;
namespace slidesix.Models
{
       public class Student
   {
    public string? Mahocsinh  { get; set; }
    public string? Tenhocsinh  { get; set; }
    public int Tuoi  { get; set; }
    public void EnterData()
    {
        System.Console.WriteLine("Ma hoc sinh = " );
        Mahocsinh = Console.ReadLine();
        System.Console.WriteLine("Ten hoc sinh = ");
        Tenhocsinh = Console.ReadLine();
         System.Console.WriteLine("tuoi = ");
        Tuoi = Convert.ToInt16(Console.ReadLine());
    }
    public void Display()
    {
        System.Console.WriteLine(Mahocsinh + "-" + Tenhocsinh + "-" + Tuoi );

    }
}
}

