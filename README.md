Bir API yazılması:
C# ile bir API geliştirildi. API’nin özellikleri aşağıdaki gibi;
○ Get / isteği atıldığı zaman "{"msg":"BC4M"}" cevabını dönmesi gerekiyor.
○ GET /health isteği attığın zaman uygulamanın sağlık durumunu kontrol eden
bir endpoint olmalıdır.
○ Post isteği atıldığında ise body’de gelen verileri geri dönmeli.
Dockerfile oluşturulması:
Uygulamanın Docker üzerinde çalışabilmesi için ilk olarak bir Dockerfile hazırlandı.
