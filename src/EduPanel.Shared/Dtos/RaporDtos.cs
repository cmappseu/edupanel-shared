namespace EduPanel.Shared.Rapor;

public record PerformansSatiri(
    Guid KullaniciId, string AdSoyad, int AramaSayisi, int UlasilanSayisi,
    int KayitSayisi, decimal Ciro, int? KayitHedefi, decimal? CiroHedefi);

public record HuniDto(
    int Toplam, int Yeni, int Arandi, int Ulasilamadi,
    int Ilgileniyor, int KayitOldu, int Vazgecti);

public record KaynakSatiri(string Kaynak, int Basvuru, int Kayit);

public record KayipSatiri(string Neden, int Sayi);

public record AylikGelir(string Ay, decimal Tutar);

public record GelirDto(
    decimal ToplamTahsilat, decimal BekleyenTaksit, decimal GecikenTaksit, List<AylikGelir> Aylik);

public record SertifikaSatiri(
    string Kurum, int Bekliyor, int Tamamlandi, int Basildi, int TeslimEdildi);

public record HedefDto(Guid KullaniciId, string AdSoyad, string Donem, int KayitHedefi, decimal CiroHedefi);

public record HedefKaydetIstek(Guid KullaniciId, string Donem, int KayitHedefi, decimal CiroHedefi);

// ── Bildirim merkezi / yönetici panosu ──

public record BekleyenSatir(string Tur, string Baslik, string? Detay);

/// <summary>Bölümler kullanıcının izinlerine göre dolar; izni olmayan bölüm null/0 kalır.</summary>
public record PanoDto(
    int? BugunBasvuru,
    int? BekleyenArama,
    decimal? BugunTahsilat,
    decimal? GecikenBorc,
    int? GecikenTaksitSayisi,
    int? SuresiYaklasanBelge,
    List<BekleyenSatir> Bekleyenler);
