namespace EduPanel.Shared.Mesajlasma;

/// <summary>Kişi listesi satırı: kim, çevrimiçi mi, okunmamış kaç mesaj var.</summary>
public record SohbetKisiDto(
    Guid KullaniciId, string AdSoyad, string? Rol,
    bool Cevrimici, int OkunmamisSayisi,
    string? SonMesaj, DateTime? SonMesajZamani);

public record MesajDto(
    Guid Id, Guid GonderenId, string GonderenAdi, Guid AliciId,
    string Icerik, DateTime Zaman, bool Okundu, bool BenGonderdim);

public record MesajGonderIstek(Guid AliciId, string Icerik);

/// <summary>Çevrimiçi durum değişikliği (SignalR ile anlık gelir).</summary>
public record CevrimiciDurumDto(Guid KullaniciId, string AdSoyad, bool Cevrimici);
