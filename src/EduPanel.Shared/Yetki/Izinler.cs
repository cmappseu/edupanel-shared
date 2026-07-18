using System.Reflection;

namespace EduPanel.Shared.Yetki;

/// <summary>
/// Tüm izin anahtarları. API'de policy adı, veritabanında RolIzin.IzinAnahtari,
/// istemcide menü/buton görünürlüğü olarak aynı sabitler kullanılır.
/// </summary>
public static class Izinler
{
    // Başvuru havuzu (CRM)
    public const string BasvurularGoruntule = "Basvurular.Goruntule";
    public const string BasvurularAra = "Basvurular.Ara";
    public const string BasvurularNotEkle = "Basvurular.NotEkle";
    public const string BasvurularDuzenle = "Basvurular.Duzenle";
    public const string BasvurularAta = "Basvurular.Ata";

    // Öğrenci ve kayıt
    public const string OgrencilerGoruntule = "Ogrenciler.Goruntule";
    public const string OgrencilerDuzenle = "Ogrenciler.Duzenle";
    public const string KayitlarGoruntule = "Kayitlar.Goruntule";
    public const string KayitlarOlustur = "Kayitlar.Olustur";
    public const string KayitlarDuzenle = "Kayitlar.Duzenle";
    public const string KayitlarIptalIade = "Kayitlar.IptalIade";

    // Eğitim kataloğu ve fiyatlar
    public const string KatalogGoruntule = "Katalog.Goruntule";
    public const string KatalogDuzenle = "Katalog.Duzenle";

    // Ödeme / tahsilat
    public const string OdemelerGoruntule = "Odemeler.Goruntule";
    public const string OdemelerTahsilatGir = "Odemeler.TahsilatGir";
    public const string OdemelerIade = "Odemeler.Iade";

    // İK / özlük / bordro
    public const string OzlukGoruntule = "Ozluk.Goruntule";
    public const string OzlukDuzenle = "Ozluk.Duzenle";
    public const string MaasGoruntule = "Maas.Goruntule";
    public const string MaasDuzenle = "Maas.Duzenle";

    // Yetki yönetimi
    public const string YetkiRolYonet = "Yetki.RolYonet";
    public const string YetkiKullaniciYonet = "Yetki.KullaniciYonet";

    // Raporlar
    public const string RaporlarPerformans = "Raporlar.Performans";
    public const string RaporlarGelir = "Raporlar.Gelir";
    public const string RaporlarHuni = "Raporlar.Huni";
    public const string RaporlarSertifika = "Raporlar.Sertifika";

    // Kurum ayarları
    public const string AyarlarKurumOzellestir = "Ayarlar.KurumOzellestir";

    /// <summary>Sistemdeki tüm izin anahtarları (yansımayla sabitlerden üretilir).</summary>
    public static IReadOnlyList<string> Tumu { get; } = typeof(Izinler)
        .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
        .Where(f => f.IsLiteral && f.FieldType == typeof(string))
        .Select(f => (string)f.GetRawConstantValue()!)
        .ToList();
}
