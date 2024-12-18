using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class song : MonoBehaviour
{
    private const string TriggerKey = "RemoveGameObject";
    public GameObject menu;
    void Awake()
    {
        // Periksa apakah pemicu tombol telah diaktifkan
        if (PlayerPrefs.GetInt(TriggerKey, 0) == 1)
        {
            // Hapus GameObject jika pemicu telah diaktifkan
            gameObject.SetActive(false);
            menu.SetActive(true);

            // Reset pemicu untuk mencegah penghapusan berulang
            PlayerPrefs.SetInt(TriggerKey, 0);
        }
    }
}
