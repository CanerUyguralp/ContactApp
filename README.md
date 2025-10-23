
# Contact App

ASP.NET Core MVC ile geliştirilmiş modern kişi yönetim uygulaması.

## Proje Hakkında

Bu proje, kullanıcıların kişi bilgilerini (isim, telefon, e-posta, departman) içeren bir formu doldurarak yönetime mesaj göndermelerini sağlayan bir web uygulamasıdır.

## Özellikler

-  Yeni mesaj ekleme
-  Mesaj silme (Admin)
-  Mesaj listesini görüntüleme (Admin)

## Kullanılan Teknolojiler

- **ASP.NET Core 9.0** - Backend framework
- **Entity Framework Core** - ORM (Object-Relational Mapping)
- **MSSQL** - Veritabanı
- **Bootstrap 5** - UI framework
- **C#** - Programlama dili

### Gereksinimler
- .NET 9.0 SDK
- SQL Server (LocalDB veya Express)
- Visual Studio 2022 veya Visual Studio Code

### Adımlar

1. **Projeyi klonlayın:**
```bash
git clone https://github.com/CanerUyguralp/ContactApp.git
cd ContactApp
```

2. **User Secrets'ı yapılandırın:**
   - Visual Studio'da projeye sağ tıklayın
   - "Manage User Secrets" seçeneğini seçin
   - Açılan `secrets.json` dosyasına şunu ekleyin:
```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ContactAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
```

3. **Veritabanını oluşturun:**
```bash
dotnet ef database update
```

4. **Uygulamayı çalıştırın:**
```bash
dotnet run
```

5. **Tarayıcıda açın:**
   - Varsayılan adres: `https://localhost:5001` veya `http://localhost:5000`

## Proje Yapısı

```
ContactApp/
├── Controllers/       # MVC Controller'ları
├── Models/           # Veri modelleri
├── Views/            # Razor view'ları
├── Data/             # DbContext ve veritabanı konfigürasyonu
├── Migrations/       # EF Core migration'ları
├── wwwroot/          # Static dosyalar (CSS, JS, resimler)
└── Program.cs        # Uygulama giriş noktası
```

## Kullanım

1. Ana sayfada Ansayda, Gizlilik, iletişim ve Admin butonları mevcuttur
2. İletişim butonuyla mesaj yazma formuna ulaşabilirsiniz
3. Admin bölümünde kullancılar taradından yazılmış mesajları görüntüleyebilir ve silebilirsiniz


## Geliştirici

**Caner Uyguralp**
- GitHub: [@CanerUyguralp](https://github.com/CanerUyguralp)

## Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

---
