# İK Takip Sistemi

## Projenin Amacı
Bu projenin amacı, insan kaynakları süreçlerini dijital ortamda yönetmeye yönelik temel bir **İK Takip Sistemi** geliştirmektir.  
Sistem; çalışan bilgileri, izin talepleri ve izin onay süreçlerinin **kullanıcı** ve **yönetici** rollerine göre yönetilmesini sağlar.  
Katmanlı mimari yaklaşımı ile veri erişimi, iş mantığı ve kullanıcı arayüzü birbirinden ayrılarak daha **sürdürülebilir**, **bakımı kolay** ve **ölçeklenebilir** bir yapı hedeflenmiştir.

## Proje Kapsamı
- Çalışan bilgilerini listeleme ve yönetme  
- Çalışanların izin talebi oluşturabilmesi  
- Yöneticilerin izin taleplerini onaylama veya reddetme  
- Rol bazlı yetkilendirme (Kullanıcı / Yönetici)  
- Temel CRUD işlemleri  

## Kullanılan Teknolojiler ve Teknikler
- C# / .NET (Windows Forms)  
- MySQL  
- Katmanlı Mimari (DAL, BLL, UI)  
- Repository Pattern  
- OOP (Nesne Yönelimli Programlama)  
- Session Yönetimi  

## Mimari Yapı
- **DAL:** Veritabanı işlemleri  
- **BLL:** İş kuralları  
- **UI:** Kullanıcı arayüzü  

## Roller
### Kullanıcı (Çalışan)
- İzin talebi oluşturabilir  
- Kendi izin geçmişini görüntüleyebilir  

### Yönetici
- Tüm çalışanları görüntüleyebilir  
- İzin taleplerini onaylayabilir veya reddedebilir  

## Ekran Görüntüleri

### Giriş Ekranı
![Giriş Ekranı](screenshots/login.png)

### Kullanıcı Ana Sayfası
![Kullanıcı Ana Sayfası](screenshots/user_main_form.png)

### Yönetici Ana Sayfası
![Yönetici Ana Sayfası](screenshots/admin_ik_main_form.png)

### Departman Yönetimi
![Departman Yönetimi](screenshots/department.png)

### Çalışan Listesi
![Çalışan Listesi](screenshots/employee_list.png)

### İzin Talep Ekranı
![İzin Talep Ekranı](screenshots/leave_request.png)

### İzin Onay Ekranı
![İzin Onay Ekranı](screenshots/leave_approval.png)

### Performans Yönetimi
![Performans Yönetimi](screenshots/performance.png)

### Maaş Yönetimi
![Maaş Yönetimi](screenshots/salary.png)

### Raporlama Ekranı
![Raporlama Ekranı](screenshots/report.png)


