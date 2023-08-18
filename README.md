# E Ticaret Uygulaması

Bu proje, [BTKAkademi](https://www.btkakademi.gov.tr/) ve [AHLATÇI EĞİTİM SAĞLIK VE YARDIMLAŞMA VAKFI](https://www.ahlatcivakfi.org.tr/) işbirliği ile gerçekleştirilen ASP.NET Core 4 haftalık atölyesinin bir parçası olarak geliştirilmiş bir E Ticaret Uygulamasıdır. Bu atölye boyunca .NET Core ile Microservice mimarisi, API Gateway Ocelot, RabbitMQ, Identity Server teknolojileri kullanılarak geliştirildi.


## İçerik

- [Proje Ayrıntıları](#proje-ayrıntıları)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Görseller](#görseller)
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
## Görseller

**1. Anasayfa**
   ![Anasayfa](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/1.png)

**2. Ürün Listesi**
   ![Ürün Listesi](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/2.png)

**3. Ürün Düzenleme**
   ![Ürün Düzenleme](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/3.png)

**4. Ürün Ekleme**
   ![Ürün Ekleme](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/4.png)

**5. Ürün Detay**
   ![Ürün Detay](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/5.png)

**6. Sepet**
   ![Sepet](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/6.png)

**7. İndirim Kuponu**
   ![İndirim Kuponu](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/7.png)

**8. Ödeme İşlemi**
   ![Ödeme İşlemi](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/8.png)

**9. Ödeme Onay**
   ![Ödeme Onay](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/9.png)

**10. Chat**
    ![Chat](https://raw.githubusercontent.com/muazerdemyigit/BtkFinalProject/main/Images/10.png)
    
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
