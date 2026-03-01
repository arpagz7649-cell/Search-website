using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // LAYAR 1: REGISTER
        Console.WriteLine("=== SISTEM RADAR KEAMANAN GEOMETRI ===");
        Console.Write("Masukkan Nama Pilot: ");
        string nama = Console.ReadLine();

        Console.Write("Buat Password Teks: ");
        string passwordTeks = Console.ReadLine();

        // PROSES KONVERSI KE GELOMBANG KABEL
        List<int> gelombangKabel = KonversiKeGelombang(passwordTeks);

        Console.WriteLine("\n--- Akun Terdaftar ---");
        Console.WriteLine("Nama: " + nama);
        Console.Write("Kunci Kabel Kamu: ");
        foreach(int angka in gelombangKabel) {
            Console.Write(angka + " "); // Ini angka naik-turunnya
        }
        Console.WriteLine("\n----------------------");

        // LAYAR 2: LOGIN (PROTEKSI)
        Console.WriteLine("\n[SISTEM TERKUNCI]");
        Console.Write("Masukkan Password untuk Akses: ");
        string inputCek = Console.ReadLine();

        if (inputCek == passwordTeks) {
            Console.WriteLine("\nAKSES DITERIMA!");
            Console.WriteLine("Halo Pilot " + nama + ", Radar Siap Digunakan.");
        } else {
            Console.WriteLine("\nAKSES DITOLAK! Virus Terdeteksi atau Password Salah.");
        }
    }

    // Fungsi "Bahasa Sendiri" untuk merubah teks jadi lekukan kabel
    static List<int> KonversiKeGelombang(string teks) {
        List<int> hasil = new List<int>();
        int posisiSekarang = 0;

        foreach (char c in teks) {
            // Logika: Huruf awal alfabet (A, B, C) bikin kabel NAIK
            // Huruf akhir (X, Y, Z) bikin kabel TURUN
            if (c < 'm') {
                posisiSekarang += 1; // Kabel naik
            } else {
                posisiSekarang -= 1; // Kabel turun
            }
            hasil.Add(posisiSekarang);
        }
        return hasil;
    }
}
