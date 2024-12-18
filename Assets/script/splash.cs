using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class splash : MonoBehaviour
{
    // Referensi ke GameObject yang akan ditampilkan dan disembunyikan
    public GameObject objectToShow;

    // Referensi ke AudioSource yang sedang memutar musik
    public AudioSource musicSource;

    // Durasi penampilan objek dalam detik
    public float displayDuration = 2f;
    // Fungsi yang dipanggil saat objek ingin ditampilkan
    private void Start()
    {
        // Tampilkan objek
        objectToShow.SetActive(true);
        
        // Jeda musik
        if (musicSource != null && musicSource.isPlaying)
        {
            musicSource.Stop();
        }

        // Jalankan Coroutine untuk menyembunyikan objek setelah beberapa detik
        StartCoroutine(HideObjectAfterDuration());
    }

    // Coroutine untuk menyembunyikan objek setelah beberapa detik
    private IEnumerator HideObjectAfterDuration()
    {
        // Tunggu durasi penampilan objek
        yield return new WaitForSeconds(displayDuration);
        
        // Sembunyikan objek
        Destroy(objectToShow);

        // Lanjutkan musik jika sebelumnya dijeda
        if (musicSource != null && !musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }
}
