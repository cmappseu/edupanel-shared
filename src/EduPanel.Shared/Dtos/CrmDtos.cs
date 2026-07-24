namespace EduPanel.Shared.Crm;

public enum BasvuruDurumu
{
    Yeni = 0,
    Arandi = 1,
    Ulasilamadi = 2,
    Ilgileniyor = 3,
    KayitOldu = 4,
    Vazgecti = 5
}

public record BasvuruDto(
    Guid Id,
    string Telefon,
    string? Ad,
    BasvuruDurumu Durum,
    string? KaynakAdi,
    Guid? AtananId,
    string? AtananAdi,
    string? SonMesaj,
    DateTime? SonMesajTarihi,
    bool KvkkRiza,
    bool PazarlamaIzni,
    Guid? VazgecmeNedeniId,
    string? VazgecmeNedeni,
    Guid? EgitimId,
    string? EgitimAdi,
    DateTime? SonAramaTarihi,
    DateTime? TekrarAramaTarihi,
    DateTime OlusturmaTarihi);

public record MesajDto(string Icerik, string? Hat, DateTime Tarih);

public record AramaDto(
    string ArayanAdi, string? Not, BasvuruDurumu SonucDurum,
    DateTime? TekrarAramaTarihi, DateTime Tarih);

public record BasvuruDetayDto(BasvuruDto Basvuru, List<MesajDto> Mesajlar, List<AramaDto> Aramalar);

/// <summary>Telefonla gelen başvurunun elle girilmesi için.</summary>
public record BasvuruOlusturIstek(string Telefon, string? Ad, string? KaynakAdi, string? Mesaj);

/// <summary>EgitimId: adayın ilgilendiği eğitim; kayda dönüştürürken hazır gelir.</summary>
public record BasvuruGuncelleIstek(string? Ad, bool KvkkRiza, bool PazarlamaIzni,
    Guid? EgitimId = null);

public record AtamaIstek(Guid? KullaniciId);

public record AramaEkleIstek(
    string? Not, BasvuruDurumu YeniDurum, DateTime? TekrarAramaTarihi, Guid? VazgecmeNedeniId);

/// <summary>Hızlı sonraki arama hatırlatması (arama kaydı doldurmadan). Tarih null = hatırlatmayı kaldır.</summary>
public record HatirlatmaIstek(DateTime? Tarih);

/// <summary>WhatsMod'un webhook'a POST edeceği sözleşme. İmza: HMAC-SHA256(gövde, kurum secret'ı) hex, X-Imza başlığında.</summary>
public record WhatsModWebhookIstek(
    string Telefon, string? Ad, string Mesaj, string? Hat, string? Kaynak, DateTime? Zaman);

public record KullaniciOzetDto(Guid Id, string AdSoyad);
