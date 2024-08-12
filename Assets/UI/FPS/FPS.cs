using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    private float fps;
    public TMPro.TextMeshProUGUI FPSText;
    void Start()
    {
        InvokeRepeating("GetFPS",1,1);
    }

    private void GetFPS()
    {
        fps = (int)(1f/Time.unscaledDeltaTime);
        FPSText.text = "FPS: " + fps.ToString();
    }

        
}
