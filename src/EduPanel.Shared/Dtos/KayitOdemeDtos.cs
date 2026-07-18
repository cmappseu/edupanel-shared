namespace EduPanel.Shared.Kayit;

public enum SertifikaDurumu
{
    Bekliyor = 0,
    Tamamlandi = 1,
    Basildi = 2,
    TeslimEdildi = 3
}

public enum OdemeYontemi
{
    Nakit = 0,
    Havale = 1,
    Kart = 2
}

// ── Öğrenci ve kayıt ──

/// <summary>Başvurudan tek tıkla kayda dönüşüm. Peşinat bugün, kalan eşit taksitlerle planlanır.</summary>
public record DonusumIstek(
    Guid BasvuruId, string AdSoyad, string? TcNo, string? Eposta,
    Guid EgitimId, decimal AnlasilanUcret, decimal Pesinat, int TaksitSayisi, DateTime? IlkVade);

public record OgrenciDto(
    Guid Id, string AdSoyad, string Telefon, string? TcNo, string? Eposta,
    int KayitSayisi, decimal ToplamKalan);

public record OgrenciGuncelleIstek(string AdSoyad, string? TcNo, string? Eposta, string Telefon);

public record KayitOzetDto(
    Guid Id, string EgitimAdi, decimal AnlasilanUcret, decimal Odenen, decimal Kalan,
    SertifikaDurumu SertifikaDurumu, bool IptalEdildi, DateTime KayitTarihi);

public record OgrenciDetayDto(OgrenciDto Ogrenci, List<KayitOzetDto> Kayitlar);

/// <summary>Mevcut öğrenciye ek eğitim kaydı.</summary>
public record YeniKayitIstek(
    Guid OgrenciId, Guid EgitimId, decimal AnlasilanUcret, decimal Pesinat,
    int TaksitSayisi, DateTime? IlkVade);

public record SertifikaGuncelleIstek(SertifikaDurumu Durum);

public record KayitIptalIstek(string Gerekce, decimal IadeTutari, decimal Kesinti);

// ── Ödeme / tahsilat ──

public record TaksitDto(
    Guid Id, DateTime Vade, decimal Tutar, decimal Odenen, decimal Kalan, DateTime? SozVerilenTarih);

public record OdemeKaydiDto(
    Guid Id, decimal Tutar, OdemeYontemi Yontem, string? MakbuzNo, string AlanAdi,
    DateTime Tarih, string? Aciklama);

public record OdemePlaniDto(
    List<TaksitDto> Taksitler, List<OdemeKaydiDto> Odemeler,
    decimal Toplam, decimal Odenen, decimal Kalan);

public record TahsilatIstek(
    Guid KayitId, Guid? TaksitId, decimal Tutar, OdemeYontemi Yontem,
    string? MakbuzNo, string? Aciklama);

/// <summary>"Ayın 15'inde yatıracak" sözünün kaydı; null tarihe söz silinir.</summary>
public record SozIstek(DateTime? Tarih);

public record BorcSatiriDto(
    Guid KayitId, Guid TaksitId, Guid OgrenciId, string OgrenciAdi, string Telefon,
    string EgitimAdi, DateTime Vade, decimal Kalan, DateTime? SozVerilenTarih, bool Gecikti);

public record KasaSatiriDto(
    string OgrenciAdi, string EgitimAdi, decimal Tutar, OdemeYontemi Yontem,
    string AlanAdi, string? MakbuzNo, DateTime Tarih);

/// <summary>Çift açılan öğrenci kartını hedefe taşır: kayıtları hedefe geçer, kaynak silinir.</summary>
public record OgrenciBirlestirIstek(Guid KaynakOgrenciId);

/// <summary>Sertifikalandıran kuruma gönderilecek dönem listesi satırı.</summary>
public record KurumListesiSatiri(
    string OgrenciAdi, string? TcNo, string Telefon, string EgitimAdi,
    DateTime KayitTarihi, SertifikaDurumu SertifikaDurumu);
