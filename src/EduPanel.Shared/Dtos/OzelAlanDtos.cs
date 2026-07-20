namespace EduPanel.Shared.OzelAlan;

/// <summary>Özel alanın veri tipi; istemci girdi denetimini buna göre seçer.</summary>
public enum OzelAlanTipi
{
    Metin = 0,
    Sayi = 1,
    Tarih = 2,
    Secim = 3,
    EvetHayir = 4
}

/// <summary>Özel alanın bağlanabileceği varlıklar.</summary>
public static class OzelAlanVarliklari
{
    public const string Basvuru = "Basvuru";
    public const string Ogrenci = "Ogrenci";

    public static readonly IReadOnlyList<string> Tumu = [Basvuru, Ogrenci];
    public static bool Gecerli(string? varlik) => varlik is not null && Tumu.Contains(varlik);
}

public record OzelAlanTanimDto(
    Guid Id, string Varlik, string Ad, OzelAlanTipi Tip, bool Zorunlu, int Sira,
    /// <summary>Seçim tipinde seçenekler; diğer tiplerde boş.</summary>
    List<string> Secenekler);

public record OzelAlanKaydetIstek(
    string Varlik, string Ad, OzelAlanTipi Tip, bool Zorunlu, int Sira, List<string>? Secenekler);

/// <summary>Bir kaydın özel alan değeri; Deger boşsa alan doldurulmamıştır.</summary>
public record OzelAlanDegerDto(Guid TanimId, string Ad, OzelAlanTipi Tip, bool Zorunlu,
    List<string> Secenekler, string? Deger);

public record OzelAlanDegerKaydetIstek(List<OzelAlanDegeriIstek> Degerler);

public record OzelAlanDegeriIstek(Guid TanimId, string? Deger);
