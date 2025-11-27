# 🌌 3D Solar System Simulation

Unity motoru ve C# kullanılarak geliştirilmiş, gerçekçi yörünge mekaniklerine ve görsel efektlere sahip bir Güneş Sistemi simülasyonu.




## 🎮 Özellikler

* **Dinamik Yörünge Sistemi:** Gezegenler Güneş etrafında farklı ve ayarlanabilir hızlarda döner (`RotateAround`).
* **Görsel Yörünge Çizimi:** Gezegenlerin izlediği rotalar `LineRenderer` kullanılarak matematiksel olarak hesaplanıp çizilir.
* **Gelişmiş Işıklandırma (Bloom):** Güneş için özel Emission materyali ve Post-Processing (Bloom) kullanılarak gerçekçi ışık saçılma efekti.
* **Gezegenler:** Merkür, Venüs, Dünya, Mars, Jüpiter, Satürn. Hepsi kendi hızlarında döner.
* **Kendi Etrafında Dönüş:** Gezegenler yörüngede dönerken aynı zamanda kendi eksenlerinde de dönerler.

## 🛠️ Kullanılan Teknolojiler

* **Oyun Motoru:** Unity 2022.3 (Senin sürümün neyse onu yaz)
* **Dil:** C#
* **Render Pipeline:** Built-in / URP (Hangisini kullandıysan)

## 🚀 Nasıl Çalıştırılır?

1.  Projeyi bilgisayarınıza indirin (Clone).
2.  Unity Hub üzerinden projeyi "Add" diyerek ekleyin.
3.  `Scenes` klasöründeki `SampleScene` (veya sahne adın neyse) sahnesini açın.
4.  Play tuşuna basın.

## 👨‍💻 Geliştirici Notları 

Bu proje Unity'de fizik, materyal yönetimi ve vektör matematiği üzerine çalışmak amacıyla geliştirilmiştir. Özellikle `[ExecuteAlways]` etiketi ile editör modunda yörüngelerin canlı önizlemesi sağlanmıştır.
