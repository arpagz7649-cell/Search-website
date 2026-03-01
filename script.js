// Fungsi untuk memanggil data dari JSON
async function muatKonten() {
    const respon = await fetch('data.json');
    const data = await respon.json();
    
    const wadah = document.getElementById('wadah-konten');
    
    data.forEach(item => {
        if(item.tipe === "status") {
            wadah.innerHTML += `<div class="status-box"><p>${item.isi}</p><span>${item.waktu}</span></div>`;
        } else {
            wadah.innerHTML += `<div class="video-box">
                <h3>${item.judul}</h3>
                <iframe src="https://www.youtube.com/embed/${item.id_short}" frameborder="0"></iframe>
            </div>`;
        }
    });
}

muatKonten();
