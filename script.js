// 1. Fungsi Munculin Form Register
function tampilForm() {
    document.getElementById('form-register').classList.toggle('hidden');
}

// 2. Fungsi Daftar (Simpan ke Memori HP)
function daftar() {
    let nama = document.getElementById('input-nama').value;
    if(nama !== "") {
        localStorage.setItem("nama_user", nama);
        alert("Pendaftaran Berhasil!");
        location.reload(); // Refresh halaman biar nama berubah
    }
}

// 3. Cek Nama User & Ambil Data JSON
async function jalankanAplikasi() {
    // Tampilkan Nama kalau sudah Daftar
    let userTerdaftar = localStorage.getItem("nama_user");
    if(userTerdaftar) {
        document.getElementById('user-info').innerHTML = `<h3>Pilot: ${userTerdaftar}</h3>`;
    }

    // Ambil Data dari JSON
    try {
        const respon = await fetch('data.json');
        const data = await respon.json();
        const wadah = document.getElementById('konten-utama');

        data.forEach(item => {
            if(item.tipe === "status") {
                wadah.innerHTML += `<div class="status-card"><p>${item.isi}</p></div>`;
            } else {
                wadah.innerHTML += `<div class="video-card">
                    <h4>${item.judul}</h4>
                    <iframe src="https://www.youtube.com/embed/${item.id_short}" frameborder="0" allowfullscreen></iframe>
                </div>`;
            }
        });
    } catch (e) {
        console.log("Gagal ambil data. Pastikan file data.json sudah ada!");
    }
}

jalankanAplikasi();
