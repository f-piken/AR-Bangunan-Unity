using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class link : MonoBehaviour
{
    public string openUrl;

    public void openlink(){
        Application.OpenURL(openUrl);
    }
}
