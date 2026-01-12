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
<img width="463" height="324" alt="login" src="https://github.com/user-attachments/assets/44357cf5-33e3-4c56-b817-2d19b32f9f02" />

Kullanıcı ve yönetici rollerine göre sisteme güvenli giriş yapılmasını sağlar.

### Kullanıcı Ana Sayfası
<img width="445" height="237" alt="user_main_form" src="https://github.com/user-attachments/assets/79ce3b64-3e09-4acc-b0c2-972b7c0a6ff3" />

Çalışanın sisteme giriş yaptıktan sonra kendi işlemlerini yönetebildiği ana ekrandır.

### Yönetici ve İK Ana Sayfası
<img width="705" height="392" alt="admin_ık_main_form" src="https://github.com/user-attachments/assets/42edc395-2453-4b68-a6c1-1d6e51bd5942" />

Yöneticilerin ve İnsan Kaynakları personellerinin sistem genelindeki işlemleri ve yönetim ekranlarını erişebildiği ana paneldir.

### Departman Yönetimi
<img width="597" height="317" alt="department" src="https://github.com/user-attachments/assets/bdfff664-cafd-482e-a4f8-0949af90b87e" />

Şirkete ait departmanların eklenmesi, güncellenmesi ve listelenmesini sağlar.

### Çalışan Listesi
<img width="931" height="482" alt="employee_list" src="https://github.com/user-attachments/assets/12b775d5-412b-4c73-aaef-f0561abf71d4" />

Sistemde kayıtlı çalışanların görüntülenmesi ve yönetilmesini sağlar.

### İzin Talep Ekranı
<img width="732" height="429" alt="leave_request" src="https://github.com/user-attachments/assets/237b77e1-2346-4cf5-84d4-0fe906252979" />

Çalışanların izin taleplerini oluşturabildiği ve başvuru yapabildiği ekrandır.

### İzin Onay Ekranı
<img width="731" height="415" alt="leave_approval" src="https://github.com/user-attachments/assets/b83ba7f2-7393-49f7-b568-cbdeb9bebeda" />

Yöneticilerin çalışanlardan gelen izin taleplerini onayladığı veya reddettiği ekrandır.

### Performans Yönetimi
<img width="749" height="425" alt="performance" src="https://github.com/user-attachments/assets/1ad99f44-b686-4983-aa58-b06e2bfa01ec" />

Çalışan performans bilgilerinin görüntülenmesi ve değerlendirilmesine yönelik ekrandır.

### Maaş Yönetimi
<img width="513" height="412" alt="salary" src="https://github.com/user-attachments/assets/d7cc2641-500f-4c11-972e-a8b904d36e6f" />

Çalışanlara ait maaş bilgilerinin yönetilmesini sağlayan ekrandır.

### Raporlama Ekranı
<img width="765" height="434" alt="report" src="https://github.com/user-attachments/assets/13d76933-e85c-47aa-b116-592a15aee2d5" />

Sistem içerisindeki verilerin raporlanarak görüntülenmesini sağlar.

## ▶ Youtube Video

📺 **Proje Tanıtım Videosu**  
Projeye ait tanıtım videosunu izlemek için  
👉 [YouTube videosunu izlemek için tıklayın](https://www.youtube.com/watch?v=imCCWFrNy0w)


