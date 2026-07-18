namespace EduPanel.Shared.Dtos;

// ── Sertifikalandıran kurumlar ──
public record KurumDto(
    Guid Id, string Ad, string? Birim, string? Telefon, string? Eposta, string? Notlar, int EgitimSayisi);

public record KurumKaydetIstek(string Ad, string? Birim, string? Telefon, string? Eposta, string? Notlar);

// ── Eğitimler ve fiyat geçmişi ──
public record FiyatDto(Guid Id, decimal EgitimUcreti, decimal BelgeUcreti, DateTime GecerliBaslangic);

public record EgitimDto(
    Guid Id, string Ad, Guid KurumId, string KurumAdi, string? Kategori,
    int? SureSaat, int? GecerlilikAy, bool Aktif, FiyatDto? GuncelFiyat);

public record EgitimKaydetIstek(
    string Ad, Guid KurumId, string? Kategori, int? SureSaat, int? GecerlilikAy, bool Aktif);

/// <summary>Yeni fiyat girişi; GecerliBaslangic boşsa hemen yürürlüğe girer. Eski satırlar geçmiş olarak kalır.</summary>
public record FiyatKaydetIstek(decimal EgitimUcreti, decimal BelgeUcreti, DateTime? GecerliBaslangic);

// ── Şubeler ──
public record SubeDto(Guid Id, string Ad, string? Adres, string? Telefon);

public record SubeKaydetIstek(string Ad, string? Adres, string? Telefon);
