function pindahKe(tujuan) {
    document.getElementById('pintu-pilihan').classList.add('hidden');
    if(tujuan === 'nonton') {
        document.getElementById('search-section').classList.remove('hidden');
    } else {
        document.getElementById('form-upload').classList.remove('hidden');
    }
}

let databaseLokal = []; // Tempat nampung kalau file JSON masih kosong

function prosesUpload() {
    let judul = document.getElementById('up-judul').value;
    let id = document.getElementById('up-id').value;
    let kode = document.getElementById('up-kode').value;

    if(judul && id && kode) {
        let dataBaru = {
            "tipe": "video",
            "judul": judul,
            "id_short": id,
            "kode_rahasia": kode
        };
        
        databaseLokal.push(dataBaru);
        // Simpan ke memori HP agar tidak hilang pas refresh
        localStorage.setItem("db_video", JSON.stringify(databaseLokal));
        
        alert("Video Berhasil Terbit! Kode Rahasiamu adalah: " + kode);
        location.reload(); 
    }
}
