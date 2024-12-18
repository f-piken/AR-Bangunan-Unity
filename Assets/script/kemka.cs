using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kemka : MonoBehaviour
{
    private const string TriggerKey = "RemoveGameObject";

    // Referensi ke UI Button yang akan digunakan untuk mengatur pemicu
    public Button triggerButton;

    void Start()
    {
        // Tambahkan listener ke Button
        triggerButton.onClick.AddListener(OnButtonClicked);
    }

    // Fungsi yang dijalankan saat Button diklik
    void OnButtonClicked()
    {
        // Aktifkan pemicu di PlayerPrefs
        PlayerPrefs.SetInt(TriggerKey, 1);

        // Pindah ke scene tujuan (nama scene harus diganti sesuai kebutuhan)
        SceneManager.LoadScene("main");
    }
}
