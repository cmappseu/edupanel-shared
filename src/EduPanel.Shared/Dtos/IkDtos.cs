namespace EduPanel.Shared.Ik;

public enum IzinTuru
{
    Yillik = 0,
    Ucretsiz = 1,
    Rapor = 2,
    Diger = 3
}

public enum OnayDurumu
{
    Bekliyor = 0,
    Onaylandi = 1,
    Reddedildi = 2
}

public record PersonelDto(
    Guid Id, string AdSoyad, string? TcNo, string? Telefon, string? Eposta,
    string? Pozisyon, DateTime IseGiris, DateTime? Cikis, Guid? KullaniciId, string? Notlar,
    Guid? SubeId, decimal? PrimYuzdesi = null);

public record PersonelKaydetIstek(
    string AdSoyad, string? TcNo, string? Telefon, string? Eposta,
    string? Pozisyon, DateTime IseGiris, DateTime? Cikis, Guid? KullaniciId, string? Notlar,
    Guid? SubeId, decimal? PrimYuzdesi = null);

/// <summary>Dönem prim önerisi: kullanıcının o ay yaptığı tahsilat × prim yüzdesi.</summary>
public record PrimSatirDto(
    Guid PersonelId, string AdSoyad, string? Pozisyon,
    decimal PrimYuzdesi, decimal Tahsilat, decimal Prim, bool BordroyaEklendi);

public record PrimBordroIstek(Guid PersonelId, string Donem);

public record BordroEpostaIstek(string Donem);

public record BelgeDto(
    Guid Id, string Tur, string DosyaAdi, long Boyut, DateTime? GecerlilikSonu, DateTime YuklemeTarihi);

/// <summary>Tutar yalnızca yetkili yanıtlarda döner; veritabanında daima şifrelidir.</summary>
public record MaasDto(Guid Id, string Donem, decimal Tutar, string? Aciklama);

public record MaasKaydetIstek(string Donem, decimal Tutar, string? Aciklama);

public record IzinDto(
    Guid Id, IzinTuru Tur, DateTime Baslangic, DateTime Bitis,
    OnayDurumu OnayDurumu, string? Aciklama);

public record IzinKaydetIstek(IzinTuru Tur, DateTime Baslangic, DateTime Bitis, string? Aciklama);

public record IzinOnayIstek(bool Onaylandi);

public record ZimmetDto(Guid Id, string Esya, DateTime TeslimTarihi, DateTime? IadeTarihi, string? Notlar);

public record ZimmetKaydetIstek(string Esya, string? Notlar);

public record PersonelDetayDto(
    PersonelDto Personel, List<BelgeDto> Belgeler, List<IzinDto> Izinler, List<ZimmetDto> Zimmetler);

public record SureliBelgeDto(
    Guid BelgeId, string PersonelAdi, string Tur, string DosyaAdi, DateTime GecerlilikSonu, bool SuresiDoldu);
