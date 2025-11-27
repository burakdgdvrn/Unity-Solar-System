using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways] // <--- ÝÞTE SÝHÝRLÝ KOD: Bu satýr kodun editörde de çalýþmasýný saðlar
[RequireComponent(typeof(LineRenderer))]
public class YorungeCizici : MonoBehaviour
{
    public Transform gunes;
    [Range(30, 100)] public int cozunurluk = 50; // Slider ekledik, ayarý kolay olsun
    public float cizgiKalinligi = 0.2f;

    private LineRenderer lineRenderer;

    // Start yerine Update kullanýyoruz ki sen objeyi sürüklediðinde çizgi de güncellensin
    void Update()
    {
        // Eðer güneþ atanmamýþsa veya oyun çalýþmýyorken hata vermemesi için kontrol
        if (gunes == null) return;

        if (lineRenderer == null)
            lineRenderer = GetComponent<LineRenderer>();

        // Ayarlarý her karede güncelle (böylece kalýnlýðý deðiþtirince anýnda görürsün)
        lineRenderer.startWidth = cizgiKalinligi;
        lineRenderer.endWidth = cizgiKalinligi;
        lineRenderer.positionCount = cozunurluk + 1;
        lineRenderer.useWorldSpace = true;

        CemberiCiz();
    }

    void CemberiCiz()
    {
        // Gezegenin güneþe olan uzaklýðýný (Yarýçap) al
        float yaricap = Vector3.Distance(new Vector3(transform.position.x, 0, transform.position.z), new Vector3(gunes.position.x, 0, gunes.position.z));

        float aciAdimi = 360f / cozunurluk;

        for (int i = 0; i <= cozunurluk; i++)
        {
            float aci = i * aciAdimi * Mathf.Deg2Rad;

            // Güneþin merkezine göre hesapla
            float x = gunes.position.x + Mathf.Sin(aci) * yaricap;
            float z = gunes.position.z + Mathf.Cos(aci) * yaricap;

            // Yörünge çizgisini gezegenin hizasýnda tut
            Vector3 nokta = new Vector3(x, transform.position.y, z);

            lineRenderer.SetPosition(i, nokta);
        }
    }
}
