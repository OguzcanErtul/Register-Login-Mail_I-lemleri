# Register-Login-Mail_Islemleri Projesi

Register-Login-Mail_Islemleri, kullanıcıların hesap oluşturmasına, giriş yapmasına ve e-posta doğrulama mekanizmasıyla güvenli bir şekilde oturum açmasına olanak tanıyan bir ASP.NET Core MVC uygulamasıdır. Proje, modern web teknolojileri ve kullanıcı dostu bir arayüzle geliştirilmiştir.

## İçindekiler
- [Özellikler](#özellikler)
- [Validasyonlar](#validasyonlar)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
---

## Özellikler

### Kullanıcı Kayıt ve Doğrulama
- E-posta adresiyle hesap oluşturma.
- Yalnızca belirli domainlerden (gmail.com, hotmail.com, outlook.com) kayıt kabul edilir.
- Kayıt sonrası doğrulama e-postası gönderimi.

### Giriş İşlemi
- Başarılı oturum açma sonrası yönlendirme.
- Hatalı girişlerde kullanıcıya uyarı mesajı.

### SweetAlert Tabanlı Validasyonlar
- Eksik veya hatalı alanlar için kullanıcı dostu uyarılar.

### E-posta Gönderimi
- MailKit ve Gmail SMTP entegrasyonu.

### Güvenli Şifreleme
- ASP.NET Identity ile kullanıcı şifrelerini güvenli bir şekilde saklama.

---

## Validasyonlar

### Zorunlu Alanlar
- **First Name**, **Last Name** ve **Email** alanlarının doldurulması gereklidir.
- Boş bırakılması durumunda kullanıcıya uyarı mesajı gösterilir.

### E-posta Formatı Kontrolü
- Giriş yapılan e-posta adresinin doğru bir formatta (örneğin: `example@gmail.com`) olup olmadığı kontrol edilir.

### Geçersiz Domainler
- Sadece `gmail.com`, `hotmail.com` ve `outlook.com` gibi geçerli domainlerden kayıt kabul edilmektedir.

### Zaten Kayıtlı E-posta
- Kullanıcı daha önce aynı e-posta ile kayıt olduysa, bir uyarı gösterilir ve işlem engellenir.

---

## Ekran Görüntüleri

### 1. Login Ekranı
![image](https://github.com/user-attachments/assets/15be292f-7c66-4a59-82fc-970ec927f5b8)
![image](https://github.com/user-attachments/assets/6ed92a62-57f8-45d2-9821-ab707db1c9d2)
![image](https://github.com/user-attachments/assets/9eef7b7a-80e3-4f35-b195-d5762c680003)

### 2. Register Ekranı
![image](https://github.com/user-attachments/assets/57d2edbf-2c5b-44a7-86cc-ad881144d3ac)
![image](https://github.com/user-attachments/assets/a4b9991c-b8ea-4be4-9140-c95d9d8951bb)
![image](https://github.com/user-attachments/assets/6496ee35-b67b-4a50-9878-24efaabe4084)
![image](https://github.com/user-attachments/assets/a01b76cf-a255-4422-849e-2d3971d13fa2)
![image](https://github.com/user-attachments/assets/3474b7f8-62de-48eb-8c21-e50cc4628873)
![image](https://github.com/user-attachments/assets/da7a428c-01d3-4dec-80d9-2c84479c2207)


### 3. E-posta Doğrulama
![E-posta Doğrulama](https://github.com/user-attachments/assets/543586ce-f640-48eb-9f6d-5e4bd97c828a)

---

## Kullanılan Teknolojiler

### Backend
- ASP.NET Core MVC
- Entity Framework Core
- Microsoft Identity

### Frontend
- Tailwind CSS
- FontAwesome
- SweetAlert

### E-posta Gönderimi
- MailKit
- Gmail SMTP

### Veritabanı
- Microsoft SQL Server

---

## Kurulum

### Gereksinimler
1. Visual Studio 2022 veya üzeri
2. .NET 6 SDK
3. Microsoft SQL Server
4. Gmail hesabı (SMTP ayarları için)

### Not
- MailService.cs dosyasındaki SMTP kimlik bilgilerini güncelleyin:
- await smtp.AuthenticateAsync("YOUR_EMAIL@gmail.com", "YOUR_APP_PASSWORD");
