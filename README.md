# E_Commerce_CSharp

>MVC5,Code First,Api,.Net

Model,View Controller nedir?

Code First nedir?

Shared dosyası nedir?

Kısıtlamalar nedir? ->    

[Column(TypeName="Varchar")]

[StringLength(30)]

-Entity Framework paketinin yüklenmesi gerekiyor,entity i yükledikten sonra projeye baktığımızda artık entity referansları olacak



-Web.config dosyasının içinde veritabanı birleştirme işlmelerimizi yapacağız.
bağlantı otomatik olmadığı için,çünkü code first ile yazdığım için.elle girmemiz gerekiyor.

 <connectionStrings>
    <add name="Context"/> burada denilmek istenen bizim Context sınıfımızdan verileri alacağı,yani bilgileri
  </connectionStrings>


bu işlem için :4.Bölüm 19. video yu izleyebilirsin.
project->add new item ->Ado.net Entity Data Model -->EF Designer from Database -->
new connection -->


  <connectionStrings>
    <add name="Context" connectionString="data source=EDA;
         initial catalog=eComDb;
         integrated security=True;"  />
  </connectionStrings>
  
  
  burada db mizi yazmış olduk
