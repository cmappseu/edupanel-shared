namespace EduPanel.Shared.Kayit;

/// <summary>Kurum etiketi (ör. "Avukata verildi"). Renk hex (#RRGGBB).</summary>
public record EtiketDto(Guid Id, string Ad, string Renk, bool Aktif);

/// <summary>Etiket oluştur/güncelle.</summary>
public record EtiketKaydetIstek(string Ad, string Renk);

/// <summary>Öğrencinin etiketlerini topluca değiştirir (verilen liste = yeni tam küme).</summary>
public record OgrenciEtiketIstek(List<Guid> EtiketIdler);
