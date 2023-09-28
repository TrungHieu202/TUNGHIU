namespace slidesix.Models
{
       public class FruitC : Fruit
   {
    public string? Maqua  { get; set; }
    public string? Tenloaiqua  { get; set; }
    public int Soluong  { get; set; }
    public string? Xuatxu  { get; set; }
    public void EnterData1()
    {

            System.Console.WriteLine("Ma qua = " );
        Maqua = Console.ReadLine();
        System.Console.WriteLine("Ten loai qua = ");
        Tenloaiqua = Console.ReadLine();
         System.Console.WriteLine("so luong = ");
        Soluong = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("xuat xu = " );
        Xuatxu  = Console.ReadLine();
}

    public void Display1()
    {
        System.Console.WriteLine(Maqua + "-" + Tenloaiqua + "-" + Soluong);

    }
   }
}  