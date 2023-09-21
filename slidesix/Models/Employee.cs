using System;
namespace slidesix.Models
{
    public class Employee
    {
    public string? MaNhanVien  { get; set; }
    public string? TenNhanVien  { get; set; }
    public int Tuoi  { get; set; }
    public int Luong  { get; set; }
    public void EnterData()
    {
        System.Console.WriteLine("Ma nhan vien = " );
        MaNhanVien = Console.ReadLine();
        System.Console.WriteLine("Ten nhan vien = " );
        TenNhanVien = Console.ReadLine();
        System.Console.WriteLine("tuoi = ");
        Tuoi = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("luong = ");
        Luong =  Convert.ToInt16(Console.ReadLine());
    }
    public void Display()
    {
        System.Console.WriteLine(MaNhanVien + "-" + TenNhanVien + "-" + Tuoi + "-" + Luong );

    }

    }
}