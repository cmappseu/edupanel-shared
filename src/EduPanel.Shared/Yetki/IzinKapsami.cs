namespace EduPanel.Shared.Yetki;

/// <summary>Bir iznin görünürlük kapsamı. "SadeceKendisi" ör. satışçının yalnız kendi maaşını görmesi.</summary>
public enum IzinKapsami
{
    Yok = 0,
    SadeceKendisi = 1,
    Herkes = 2
}
