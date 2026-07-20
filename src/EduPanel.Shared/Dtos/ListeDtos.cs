namespace EduPanel.Shared.Listeler;

/// <summary>
/// Kurumun kendi yönettiği seçim listeleri. Anahtar kodda sabittir; içerik kuruma göre değişir.
/// </summary>
public static class ListeAnahtarlari
{
    public const string VazgecmeNedeni = "VazgecmeNedeni";
    public const string BelgeTuru = "BelgeTuru";
    public const string Pozisyon = "Pozisyon";

    public static readonly IReadOnlyList<string> Tumu = [VazgecmeNedeni, BelgeTuru, Pozisyon];
    public static bool Gecerli(string? liste) => liste is not null && Tumu.Contains(liste);

    /// <summary>Yeni kurum açılırken yüklenen başlangıç içerikleri.</summary>
    public static readonly IReadOnlyDictionary<string, string[]> Varsayilanlar =
        new Dictionary<string, string[]>
        {
            [VazgecmeNedeni] = ["Fiyat", "Zamanlama", "Rakip kurum", "İlgisini kaybetti", "Diğer"],
            [BelgeTuru] = ["Sözleşme", "Kimlik fotokopisi", "Diploma", "Sağlık raporu", "Diğer"],
            [Pozisyon] = ["Satış Elemanı", "Muhasebe", "Şube Müdürü", "Eğitmen", "İdari Personel"]
        };
}

public record ListeOgesiDto(Guid Id, string Liste, string Deger, int Sira, bool Aktif);

public record ListeOgeKaydetIstek(string Liste, string Deger, int Sira, bool Aktif);
