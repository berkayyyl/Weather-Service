# Weather Service
 Weather Service C# .NET Core

# Hava Durumu Uygulaması 🌤️

Bu proje, kullanıcıların bir konum girerek gerçek zamanlı hava durumu bilgilerini almasını sağlayan basit bir **Hava Durumu Uygulaması**dır. Uygulama, üçüncü parti bir API kullanarak hava durumu verilerini çeker ve sıcaklık, konum bilgileri ve hava durumu koşullarını ekrana getirir.

## Özellikler 🚀

- 🌍 **Şehir Arama**: Kullanıcılar istedikleri şehri girerek o bölgenin hava durumu bilgilerine ulaşabilirler.
- 📅 **Güncel Hava Durumu**: Girilen konumun anlık sıcaklığı, hava durumu açıklaması ve yerel saati ekranda gösterilir.
- 📌 **Bölge ve Ülke Bilgisi**: Konumun hangi bölge ve ülkede olduğunu gösterir.
- 🗺️ **Harita Görselleştirmesi**: Kullanıcılar, Mapbox API kullanarak aradıkları konumu harita üzerinde görebilirler.
- 💻 **Duyarlı (Responsive) Tasarım**: Farklı cihazlarda düzgün çalışan bir arayüze sahiptir.

## Kullanılan Teknolojiler ⚙️

- **Dil**: C# (ASP.NET Core)
- **IDE**: Visual Studio 2022
- **Frontend**: Razor Pages (`cshtml`), HTML5, CSS3
- **Backend**: ASP.NET Core MVC
- **Hava Durumu API**: [Weatherstack API](https://weatherstack.com/)
- **Harita API**: [Mapbox API](https://www.mapbox.com/)
- **Veri Testi**: Postman ile API testi
- **Versiyon Kontrolü**: Git & GitHub

## Kurulum ve Çalıştırma 🛠️

1. **Projeyi Klonlayın**:
   ```bash
   git clone https://github.com/kullaniciadi/WeatherApplication.git
   ```
2. **API Anahtarlarını Ayarlayın**:
   - Weatherstack API ve Mapbox API’den aldığınız API anahtarlarını projedeki uygun yerlere ekleyin.
3. **Projeyi Çalıştırın**:
   - Visual Studio 2022 ile projeyi açın ve `Run` butonuna tıklayın.
4. **Hava Durumu Bilgilerini Alın**:
   - Tarayıcıda açılan uygulamada bir şehir ismi girerek hava durumu verilerini görüntüleyin.
