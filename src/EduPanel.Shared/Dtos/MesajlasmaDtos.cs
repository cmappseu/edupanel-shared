namespace EduPanel.Shared.Mesajlasma;

/// <summary>Kişi listesi satırı: kim, çevrimiçi mi, okunmamış kaç mesaj var.</summary>
public record SohbetKisiDto(
    Guid KullaniciId, string AdSoyad, string? Rol,
    bool Cevrimici, int OkunmamisSayisi,
    string? SonMesaj, DateTime? SonMesajZamani);

/// <summary>
/// Tek mesaj. Metin ve/veya dosya taşıyabilir. Dosya alanları doluysa
/// baloncukta ek kartı gösterilir; içerik indirme ucundan alınır.
/// </summary>
public record MesajDto(
    Guid Id, Guid GonderenId, string GonderenAdi, Guid AliciId,
    string Icerik, DateTime Zaman, bool Okundu, bool BenGonderdim,
    string? DosyaAd = null, string? DosyaTur = null, long? DosyaBoyut = null)
{
    /// <summary>Bu mesaj bir dosya taşıyor mu.</summary>
    public bool DosyaVar => DosyaAd is not null;

    /// <summary>Dosya bir görsel mi (satır içi önizleme için).</summary>
    public bool Gorsel => DosyaTur is not null && DosyaTur.StartsWith("image/");
}

public record MesajGonderIstek(Guid AliciId, string Icerik);

/// <summary>Çevrimiçi durum değişikliği (SignalR ile anlık gelir).</summary>
public record CevrimiciDurumDto(Guid KullaniciId, string AdSoyad, bool Cevrimici);

// ── Yönetici gözetimi: tüm konuşmaları görebilme ──

/// <summary>Gözetim ekranındaki bir konuşma satırı: iki kişi, son mesaj ve toplam adet.</summary>
public record GozetimKonusmaDto(
    Guid KisiAId, string KisiAAd, Guid KisiBId, string KisiBAd,
    string? SonMesaj, DateTime SonZaman, int Adet, bool DosyaSonda);
