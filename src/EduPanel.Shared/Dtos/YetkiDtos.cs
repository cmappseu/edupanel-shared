using EduPanel.Shared.Yetki;

namespace EduPanel.Shared.Dtos;

/// <summary>İzin kataloğu satırı: "Basvurular.Goruntule" → Modul=Basvurular, Eylem=Goruntule.</summary>
public record IzinTanimi(string Anahtar, string Modul, string Eylem);

public record RolIzinDto(string IzinAnahtari, IzinKapsami Kapsam);

public record RolDto(
    Guid Id,
    string Ad,
    string? Aciklama,
    bool SistemRolu,
    int KullaniciSayisi,
    List<RolIzinDto> Izinler);

public record RolKaydetIstek(string Ad, string? Aciklama, List<RolIzinDto> Izinler);

public record KullaniciDto(
    Guid Id,
    string Eposta,
    string AdSoyad,
    Guid RolId,
    string RolAdi,
    bool Aktif);

public record KullaniciOlusturIstek(string Eposta, string AdSoyad, string Sifre, Guid RolId);

public record KullaniciGuncelleIstek(string AdSoyad, Guid RolId, bool Aktif);

public record SifreSifirlaIstek(string YeniSifre);
