using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GezegenDonusu : MonoBehaviour
{
    [Header("Ayarlar")]
    public Transform gunes;   // Etrafýnda dönülecek merkez obje
    public float donusHizi;   // Bu gezegenin hýzý

    void Update()
    {
        // Eðer güneþ seçili deðilse hata vermesin diye kontrol ediyoruz
        if (gunes != null)
        {
            // RotateAround(Merkez Nokta, Hangi Eksen, Hýz)
            // Vector3.up = Y ekseni (Tepsi gibi yatay dönmesi için)
            transform.RotateAround(gunes.position, Vector3.up, donusHizi * Time.deltaTime);
            // Kendi etrafýnda yavaþça dön
            transform.Rotate(Vector3.up, 15 * Time.deltaTime);
        }
    }
}
