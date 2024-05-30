namespace StringLocalizer
{
    public class DeterminesOfCodes
    {
        /*
         * // StringLocalizer.Extensions ad alanı, bu sınıfın ve genişletme metodunun yer aldığı yerdir.
namespace StringLocalizer.Extensions
{
    // DependencyInjection adında bir statik sınıf tanımlanıyor.
    public static class DependencyInjection
    {
        // AddMVCServices adında bir genişletme metodu tanımlanıyor. Bu metod, IServiceCollection türünde bir parametre alıyor.
        public static IServiceCollection AddMVCServices(this IServiceCollection services)
        {
            // Localization hizmeti ekleniyor ve kaynak dosyaların bulunduğu dizin "Resources" olarak ayarlanıyor.
            services.AddLocalization(options => options.ResourcesPath = "Resources");

            // RequestLocalizationOptions yapılandırılıyor.
            services.Configure<RequestLocalizationOptions>(opt =>
            {
                // Desteklenen kültürler tanımlanıyor. İngilizce (en) ve Türkçe (tr) kültürleri destekleniyor.
                var supCultures = new List<CultureInfo>()
                {
                    new CultureInfo("en"),
                    new CultureInfo("tr"),
                };

                // Varsayılan istek kültürü Türkçe (tr) olarak ayarlanıyor.
                opt.DefaultRequestCulture = new RequestCulture("tr");

                // Desteklenen kullanıcı arayüzü (UI) kültürleri listesi ayarlanıyor.
                opt.SupportedUICultures = supCultures;
            });

            // Servis koleksiyonu geri döndürülüyor, böylece bu genişletme metodu çağrıldığında diğer konfigürasyonlar da eklenebilir.
            return services;
        }
    }
}




        // HTML belgesinde ID'si 'selectLanguage' olan elementi seç ve 'change' (değişim) olayını dinle
document.getElementById('selectLanguage').addEventListener('change', function () {
    
    // Kullanıcının dropdown menüsünden seçtiği dili al
    // 'this' ifadesi, şu anda olay dinleyiciye bağlı olan elemente referans eder (bu durumda 'selectLanguage' elementine)
    var selectedLanguage = this.value;
    
    // Yeni bir çerez oluştur ve dil tercihlerini belirle
    // '.AspNetCore.Culture' çerezi uygulamanın dilini belirler ve kültür ('c') ile kullanıcı arayüzü kültürü ('uic') için seçilen dili kullanır
    document.cookie = ".AspNetCore.Culture=c=" + selectedLanguage + "|uic=" + selectedLanguage + ";path=/";
    
    // Sayfayı yeniden yükle, böylece yeni dil tercihi uygulanır
    location.reload();
    
    // Mevcut çerezleri konsola yazdır, bu hata ayıklama ve doğrulama için kullanışlıdır
    console.log(document.cookie);
});



        document.cookie: JavaScript'te çerez ayarlamak için kullanılır.
".AspNetCore.Culture=c=" + selectedLanguage + "|uic=" + selectedLanguage: Çerez değeri, seçilen dili hem kültür (c) hem de kullanıcı arayüzü kültürü (uic) için ayarlar.
";path=/": Çerez yolunu kök dizin (/) olarak ayarlar. Bu, çerezin uygulamanın tüm yollarında geçerli olmasını sağlar.

         * 
         * 
         */
    }
}
