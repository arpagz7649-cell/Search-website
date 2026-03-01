using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        // --- LAYAR REGISTER ---
        Console.WriteLine("=== REGISTER AKUN PILOT BARU ===");
        
        Console.Write("Masukkan Username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan Nama Asli: ");
        string namaAsli = Console.ReadLine();

        Console.Write("Buat Password: ");
        // Kita pakai password teks dulu, nanti sistem otomatis ubah ke gelombang
        string passwordTeks = Console.ReadLine();

        // PROSES: Mengubah password menjadi "Bahasa Kabel" (Angka Gelombang)
        List<int> kunciKabel = KonversiKeGelombang(passwordTeks);

        Console.WriteLine("\n[Sistem]: Akun Berhasil Dibuat!");
        Console.WriteLine("--------------------------------");

        // --- LAYAR LOGIN (Pintu Keamanan) ---
        Console.WriteLine("\n=== LOGIN SISTEM RADAR ===");
        
        Console.Write("Masukkan Username: ");
        string loginUser = Console.ReadLine();

        Console.Write("Masukkan Password: ");
        string loginPass = Console.ReadLine();

        // Validasi: Cek apakah Username dan Password benar
        if (loginUser == username && loginPass == passwordTeks) {
            Console.WriteLine("\n[AKSES DITERIMA]");
            Console.WriteLine("Selamat Datang, Pilot " + namaAsli);
            Console.WriteLine("Status Radar: Aktif");
            
            // Menampilkan kode kabel rahasia sebagai identitas unik
            Console.Write("ID Gelombang Kamu: ");
            foreach(int koordinat in kunciKabel) {
                Console.Write(koordinat + " ");
            }
            Console.WriteLine("\n--------------------------------");
        } else {
            Console.WriteLine("\n[AKSES DITOLAK]");
            Console.WriteLine("Username atau Password Salah! Sistem Terkunci.");
        }
    }

    // Fungsi "Bahasa Sendiri" untuk merubah teks jadi lekukan kabel (Naik-Turun)
    static List<int> KonversiKeGelombang(string teks) {
        List<int> hasil = new List<int>();
        int posisi = 0;

        foreach (char c in teks.ToLower()) {
            // Logika: a-m kabel NAIK (+1), n-z kabel TURUN (-1)
            if (c >= 'a' && c <= 'm') {
                posisi += 1;
            } else if (c >= 'n' && c <= 'z') {
                posisi -= 1;
            }
            hasil.Add(posisi);
        }
        return hasil;
    }
}
