using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteNoiseBGAudio : MonoBehaviour
{
    public static whiteNoiseBGAudio instance;

    void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
