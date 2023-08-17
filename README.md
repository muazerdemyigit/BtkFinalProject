# E Ticaret Uygulaması

Bu proje, [BTKAkademi](https://www.btkakademi.gov.tr/) ve [AHLATÇI EĞİTİM SAĞLIK VE YARDIMLAŞMA VAKFI](https://www.ahlatcivakfi.org.tr/) işbirliği ile gerçekleştirilen ASP.NET Core 4 haftalık atölyesinin bir parçası olarak geliştirilmiş bir E Ticaret Uygulamasıdır. Bu atölye boyunca .NET Core ile Microservice mimarisi, API Gateway Ocelot, RabbitMQ, Identity Server teknolojileri kullanılarak geliştirildi.


## İçerik

- [Proje Ayrıntıları](#proje-ayrıntıları)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Admin-Customer Mesajlaşma Özelliği](#admin-customer-mesajlaşma-özelliği)
- [Eğitmen](#eğitmen)
- [Lisans](#lisans)

## Proje Ayrıntıları

Bu projede, aşağıdaki teknolojiler kullanıldı:

- ASP.NET Core: Web uygulamasının temel platformu.
- Microservice Mimarisi: Uygulama, bağımsız hizmetlere ayrılarak geliştirildi.
- API Gateway Ocelot: Hizmetler arasındaki iletişimi yönetmek için kullanıldı.
- RabbitMQ: İletişim için yaygın olarak kullanılan bir mesaj kuyruğu sistemi.
- Identity Server: Kimlik doğrulama ve yetkilendirme yönetimi sağlamak için kullanıldı.
- Iyzico Entegrasyonu: Ödeme işlemleri için Iyzico servisi entegre edildi.

## Kurulum

1. Bu projeyi klonlayın veya ZIP dosyası olarak indirin.
2. Proje kök dizinine gidin.

## Kullanım

1. Proje kök dizininde terminali açın.
2. Gerekli bağımlılıkları yüklemek için aşağıdaki komutu çalıştırın:

```bash
dotnet restore
```
Uygulamayı başlatmak için aşağıdaki komutu çalıştırın:
```bash
dotnet run
```
## Admin-Customer Mesajlaşma Özelliği

Bu projede, admin kullanıcıları ile müşteri kullanıcıları arasında gerçek zamanlı mesajlaşma özelliği entegre edilmiştir. Bu özellik sayesinde müşteri hizmetleri temsilcileri (adminler), müşteri kullanıcıları ile doğrudan iletişim kurabilir ve sorularını yanıtlayabilir.

### Kullanım

1. Admin hesabıyla giriş yapın.
2. Admin panelinde "Mesajlaşma" ikonuna tıklayarak bir sekmeye gidin.
3. Mesaj göndermek için metin kutusuna mesajınızı yazın ve "Gönder" düğmesine tıklayın.
4. Müşteri de hesabına giriş yaptığında, admin tarafından gönderilen mesajları alabilir ve cevaplayabilir.
5. İletişimi gerçek zamanlı olarak takip edebilirsiniz.

Bu özellik, adminlerin müşteri ihtiyaçlarına daha hızlı ve etkili bir şekilde yanıt verebilmesini sağlar. Ayrıca, müşteri deneyimini iyileştirerek iletişim sürecini kolaylaştırır.


## Eğitmen
- [İbrahim GÖKYAR](https://www.linkedin.com/in/ibrahimgokyar/)


## Lisans
Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için [LİSANS](https://github.com/muazerdemyigit/BtkFinalProject/blob/main/LICENSE) dosyasına bakın.
```bash

Bu Markdown kodunu kopyalayıp bir README.md dosyasına yapıştırarak kullanabilirsiniz. Tabii ki, kendi projenize özgü ayrıntıları ve bağlantıları eklemeyi unutmayın.

```
