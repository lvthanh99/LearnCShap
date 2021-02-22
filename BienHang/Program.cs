using System;
using static System.Console;

namespace BienHang
{
    // Bien can co gia tri khi khoi tao.
    // Co the dung tu khoa var de thay the kieu gia tri khi dinh nghia 1 bien.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteLine("Hello word!");
            int i = 0;
            WriteLine(i);


            Write("Nhap vao so nguyen i: ");
            i = int.Parse(ReadLine()); // chuyen so nguyen nhap tu ban phim tu kieu string sang int
            WriteLine("So nguyen vua nhap la: {0}", i);
            WriteLine($"So nguyen vua nhap la {i}");
        }
    }
}
