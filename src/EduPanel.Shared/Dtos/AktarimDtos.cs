namespace EduPanel.Shared.Aktarim;

/// <summary>Aktarım satırının sonucu. Durum: Eklendi / Eklenecek / Atlandı / Hata.</summary>
public record AktarimSatirSonucu(int Satir, string Durum, string Mesaj);

public record AktarimOzeti(
    int Toplam, int Basarili, int Atlanan, int Hatali, bool Uygulandi,
    List<AktarimSatirSonucu> Satirlar);
