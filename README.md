Register-Login-Mail_Islemleri Projesi
HS14 Register, kullanıcıların hesap oluşturmasına, giriş yapmasına ve e-posta doğrulama mekanizmasıyla güvenli bir şekilde oturum açmasına olanak tanıyan bir ASP.NET Core MVC uygulamasıdır. Proje, modern web teknolojileri ve kullanıcı dostu bir arayüzle geliştirilmiştir.

Özellikler
1-Kullanıcı Kayıt ve Doğrulama:
*E-posta adresiyle hesap oluşturma.
*Yalnızca belirli domainlerden (gmail.com, hotmail.com, outlook.com) kayıt kabul edilir.
*Kayıt sonrası doğrulama e-postası gönderimi.
2-Giriş İşlemi:
*Başarılı oturum açma sonrası yönlendirme.
*Hatalı girişlerde kullanıcıya uyarı mesajı.
*SweetAlert Tabanlı Validasyonlar:
*Eksik veya hatalı alanlar için kullanıcı dostu uyarılar.
3-E-posta Gönderimi:
*MailKit ve Gmail SMTP entegrasyonu.
*Güvenli Şifreleme:
*ASP.NET Identity ile kullanıcı şifrelerini güvenli bir şekilde saklama.


Validasyonlar
1-Zorunlu Alanlar:
First Name, Last Name ve Email alanlarının doldurulması gereklidir. Boş bırakılması durumunda kullanıcıya uyarı mesajı gösterilir.
2-E-posta Formatı Kontrolü:
Giriş yapılan e-posta adresinin doğru bir formatta (example@gmail.com) olup olmadığı kontrol edilir.
3-Geçersiz Domainler:
Sadece gmail.com, hotmail.com ve outlook.com gibi geçerli domainlerden kayıt kabul edilmektedir.
4-Zaten Kayıtlı E-posta:
Kullanıcı daha önce aynı e-posta ile kayıt olduysa, bir uyarı gösterilir ve işlem engellenir.


Aşağıda projeniz için tam bir README.md dosyasını hazırladım. Bunu kopyalayıp doğrudan README.md dosyasına yapıştırabilirsiniz.

HS14 Register Projesi
HS14 Register, kullanıcıların hesap oluşturmasına, giriş yapmasına ve e-posta doğrulama mekanizmasıyla güvenli bir şekilde oturum açmasına olanak tanıyan bir ASP.NET Core MVC uygulamasıdır. Proje, modern web teknolojileri ve kullanıcı dostu bir arayüzle geliştirilmiştir.

İçindekiler
Özellikler
Validasyonlar
Ekran Görüntüleri
Kullanılan Teknolojiler
Kurulum
Kullanım
Proje Yapısı
Geliştirici Hakkında
Lisans
Özellikler
Kullanıcı Kayıt ve Doğrulama:
E-posta adresiyle hesap oluşturma.
Yalnızca belirli domainlerden (gmail.com, hotmail.com, outlook.com) kayıt kabul edilir.
Kayıt sonrası doğrulama e-postası gönderimi.
Giriş İşlemi:
Başarılı oturum açma sonrası yönlendirme.
Hatalı girişlerde kullanıcıya uyarı mesajı.
SweetAlert Tabanlı Validasyonlar:
Eksik veya hatalı alanlar için kullanıcı dostu uyarılar.
E-posta Gönderimi:
MailKit ve Gmail SMTP entegrasyonu.
Güvenli Şifreleme:
ASP.NET Identity ile kullanıcı şifrelerini güvenli bir şekilde saklama.
Validasyonlar
Validasyon Mekanizması
Zorunlu Alanlar:
First Name, Last Name ve Email alanlarının doldurulması gereklidir. Boş bırakılması durumunda kullanıcıya uyarı mesajı gösterilir.
E-posta Formatı Kontrolü:
Giriş yapılan e-posta adresinin doğru bir formatta (example@gmail.com) olup olmadığı kontrol edilir.
Geçersiz Domainler:
Sadece gmail.com, hotmail.com ve outlook.com gibi geçerli domainlerden kayıt kabul edilmektedir.
Zaten Kayıtlı E-posta:
Kullanıcı daha önce aynı e-posta ile kayıt olduysa, bir uyarı gösterilir ve işlem engellenir.
Validasyon Örnekleri
E-posta Alanı Boş
Kullanıcı Email alanını boş bırakırsa:

plaintext
Kodu kopyala
SweetAlert Uyarısı:
- Başlık: "Email Missing"
- Mesaj: "Please enter your email address."
Geçersiz E-posta Formatı
Kullanıcı Email alanına example@ gibi geçersiz bir değer girerse:

plaintext
Kodu kopyala
SweetAlert Uyarısı:
- Başlık: "Invalid Email Format"
- Mesaj: "Please enter a valid email address."
Geçersiz Domain
Kullanıcı example@yahoo.com gibi geçersiz bir domain ile kayıt olmaya çalışırsa:

plaintext
Kodu kopyala
SweetAlert Uyarısı:
- Başlık: "Invalid Email Domain"
- Mesaj: "Please use a valid email domain (e.g., gmail.com, hotmail.com, outlook.com)."
Zaten Kayıtlı E-posta
Kullanıcı daha önce kayıtlı bir e-posta ile kayıt olmaya çalışırsa:

Ekran Görüntüleri
1-Login Ekranı
![image](https://github.com/user-attachments/assets/15be292f-7c66-4a59-82fc-970ec927f5b8)
![image](https://github.com/user-attachments/assets/6ed92a62-57f8-45d2-9821-ab707db1c9d2)
![image](https://github.com/user-attachments/assets/9eef7b7a-80e3-4f35-b195-d5762c680003)

2-Register Ekranı
![image](https://github.com/user-attachments/assets/57d2edbf-2c5b-44a7-86cc-ad881144d3ac)
![image](https://github.com/user-attachments/assets/a4b9991c-b8ea-4be4-9140-c95d9d8951bb)
![image](https://github.com/user-attachments/assets/6496ee35-b67b-4a50-9878-24efaabe4084)
![image](https://github.com/user-attachments/assets/a01b76cf-a255-4422-849e-2d3971d13fa2)
3-E-posta Doğrulama
![image](https://github.com/user-attachments/assets/543586ce-f640-48eb-9f6d-5e4bd97c828a)

Kullanılan Teknolojiler
1-Backend
-ASP.NET Core MVC
-Entity Framework Core
-Microsoft Identity
2-Frontend
-Tailwind CSS
-FontAwesome
-SweetAlert
3-E-posta Gönderimi
-MailKit
-Gmail SMTP
4-Veritabanı
-Microsoft SQL Server


Kurulum gereksinimleri
Visual Studio 2022 veya üzeri
.NET 6 SDK
Microsoft SQL Server
Gmail hesabı (SMTP ayarları için)

Gmail SMTP Ayarlarını Yapın:
MailService.cs dosyasındaki SMTP kimlik bilgilerini güncelleyin:
await smtp.AuthenticateAsync("YOUR_EMAIL@gmail.com", "YOUR_APP_PASSWORD");
