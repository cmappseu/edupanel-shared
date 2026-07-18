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
    bool Aktif,
    Guid? SubeId,
    string? SubeAdi);

public record KullaniciOlusturIstek(string Eposta, string AdSoyad, string Sifre, Guid RolId, Guid? SubeId);

public record KullaniciGuncelleIstek(string AdSoyad, Guid RolId, bool Aktif, Guid? SubeId);

/// <summary>Denetim günlüğü satırı: kim, ne zaman, hangi kayıtta ne yaptı.</summary>
public record DenetimSatiri(
    DateTime Zaman, string KullaniciAdi, string Eylem, string Varlik, Guid VarlikId, string? Ozet);

public record SifreSifirlaIstek(string YeniSifre);
