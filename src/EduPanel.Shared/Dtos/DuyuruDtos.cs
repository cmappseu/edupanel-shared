namespace EduPanel.Shared.Duyurular;

/// <summary>Duyurunun aciliyeti; istemci rengi ve simgeyi buna göre seçer.</summary>
public enum DuyuruTuru
{
    Bilgi = 0,
    Uyari = 1,
    Kritik = 2
}

public record DuyuruDto(
    Guid Id, string Baslik, string Icerik, DuyuruTuru Tur,
    DateTime Baslangic, DateTime? Bitis, bool Yayinda,
    /// <summary>Yalnız bu role gösterilir; null ise herkese.</summary>
    Guid? HedefRolId, string? HedefRolAdi,
    bool Okundu, DateTime OlusturmaTarihi);

public record DuyuruKaydetIstek(
    string Baslik, string Icerik, DuyuruTuru Tur,
    DateTime Baslangic, DateTime? Bitis, bool Yayinda, Guid? HedefRolId);

/// <summary>Zil panelindeki tek bir satır (duyuru, güncelleme ya da hatırlatma).</summary>
public record BildirimSatiri(
    string Kaynak,        // Duyuru / Guncelleme / Hatirlatma
    string Tur,           // Bilgi / Uyari / Kritik / Arama / Borc / Soz / Belge
    string Baslik,
    string? Detay,
    string Anahtar,
    bool Okundu,
    DateTime? Zaman);
