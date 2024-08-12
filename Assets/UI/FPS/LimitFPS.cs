using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    public int targetFPS = 300;
    void Start()
    {
        QualitySettings.vSyncCount =0;
        Application.targetFrameRate = targetFPS;
        DontDestroyOnLoad(gameObject);
    }
}
