using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ObjectActivator : MonoBehaviour
{
    // Game object yang akan diaktifkan atau dinonaktifkan
    public GameObject objectToToggle;

    // Pilihan apakah game object akan diaktifkan atau dinonaktifkan saat berpindah scene
    public bool activateObject = true;

    private void Awake()
    {
        // Mencegah game object ini dihancurkan saat berpindah scene
        DontDestroyOnLoad(gameObject);

        // Mendaftarkan method LoadSceneCallback() untuk dipanggil saat scene berpindah
        SceneManager.sceneLoaded += LoadSceneCallback;
    }

    private void OnDestroy()
    {
        // Membersihkan subscription method saat game object dihancurkan
        SceneManager.sceneLoaded -= LoadSceneCallback;
    }

    // Method yang dipanggil saat scene berpindah
    private void LoadSceneCallback(Scene scene, LoadSceneMode mode)
    {
        // Cek apakah game object harus diaktifkan atau dinonaktifkan
        if (activateObject)
        {
            // Mengaktifkan game object
            objectToToggle.SetActive(true);
        }
        else
        {
            // Menonaktifkan game object
            objectToToggle.SetActive(false);
        }
    }
}

