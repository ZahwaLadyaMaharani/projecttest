using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Menghitung Luas Segitiga");

        // Input panjang alas
        Console.Write("Masukkan panjang alas: ");
        double alas = Convert.ToDouble(Console.ReadLine());

        // Input tinggi segitiga
        Console.Write("Masukkan tinggi segitiga: ");
        double tinggi = Convert.ToDouble(Console.ReadLine());

        // Hitung dan tampilkan luas segitiga
        double luas = HitungLuasSegitiga(alas, tinggi);
        Console.WriteLine($"Luas segitiga adalah: {luas}");

        // Tunggu agar pengguna dapat melihat hasilnya
        Console.ReadLine();
    }

    public static double HitungLuasSegitiga(double alas, double tinggi)
    {
        return 0.5 * alas * tinggi;
    }
}
