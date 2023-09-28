using System.Dynamic;
namespace slidesix.Models
{
       public class Fruit
   {
    public string? Maqua  { get; set; }
    public string? Tenloaiqua  { get; set; }
    public int Soluong  { get; set; }
    public void EnterData1()
    {
try{
            System.Console.WriteLine("Ma qua = " );
        Maqua = Console.ReadLine();
        System.Console.WriteLine("Ten loai qua = ");
        Tenloaiqua = Console.ReadLine();
         System.Console.WriteLine("so luong = ");
        Soluong = Convert.ToInt16(Console.ReadLine());
}
catch{
    Soluong = 0;
}
    }
    public void Display1()
    {
        System.Console.WriteLine(Maqua + "-" + Tenloaiqua + "-" + Soluong);

    }
}
}