# edupanel-shared

EduPanel'in sunucu (edupanel-server) ve masaüstü istemci (edupanel-desktop) tarafından ortak kullanılan sözleşmeleri içerir:

- **DTO'lar** — API istek/yanıt tipleri
- **İzin sabitleri** — RBAC izin anahtarları (`Basvurular.Goruntule` gibi) ve kapsam enum'u

> Bu repo, `edupanel-server` ve `edupanel-desktop` ile **yan yana** klonlanmalıdır;
> diğer repolar bu projeye kardeş klasör üzerinden ProjectReference verir.
> İleride CI'da NuGet paketi olarak yayınlanabilir.

```
D:\Calisma\
├─ edupanel-shared\
├─ edupanel-server\
└─ edupanel-desktop\
```
