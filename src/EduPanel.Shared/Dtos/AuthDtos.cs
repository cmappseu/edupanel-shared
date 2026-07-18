namespace EduPanel.Shared.Dtos;

public record GirisIstek(string KurumKodu, string Eposta, string Sifre);

public record YenilemeIstek(string KurumKodu, string RefreshToken);

/// <summary>Izinler: "Anahtar:Kapsam" biçiminde, ör. "Maas.Goruntule:SadeceKendisi".</summary>
public record GirisYanit(
    string AccessToken,
    string RefreshToken,
    DateTime AccessSonu,
    string AdSoyad,
    string Eposta,
    string Rol,
    string KurumKodu,
    string KurumAdi,
    List<string> Izinler);
