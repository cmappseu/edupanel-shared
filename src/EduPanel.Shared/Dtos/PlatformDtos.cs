namespace EduPanel.Shared.Platform;

/// <summary>Lisanslanabilir modül kataloğu; menüler lisans ∩ izin ile açılır.</summary>
public static class ModulKatalogu
{
    public static readonly (string Ad, string Baslik)[] Tumu =
    [
        ("Crm", "Başvuru Havuzu"),
        ("Catalog", "Eğitim Kataloğu"),
        ("Enrollment", "Öğrenci & Kayıt"),
        ("Payments", "Tahsilat"),
        ("Hr", "İK / Bordro"),
        ("Reports", "Raporlar")
    ];
}

// ── Süper yönetim (yalnız platform yöneticisi kurum) ──

public record KurumOzetDto(
    Guid Id, string Kod, string Ad, bool Aktif, bool PlatformYoneticisiMi,
    string? WebhookSecret, List<string> Moduller, DateTime OlusturmaTarihi);

public record KurumOlusturIstek(
    string Kod, string Ad, string AdminEposta, string AdminSifre,
    string? WebhookSecret, List<string> Moduller);

public record KurumGuncelleIstek(string Ad, bool Aktif, string? WebhookSecret);

public record LisansGuncelleIstek(List<string> Moduller);

// ── Kurum özelleştirme (her kurumun kendi ayarları) ──

public record KurumOzellestirmeDto(
    string? GorunenAd,
    string? VurguRenk,
    string? MakbuzOnEk,
    decimal? IadeKesintiYuzde,
    string? KvkkMetni);
