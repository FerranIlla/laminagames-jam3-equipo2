using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespiration : MonoBehaviour
{

    AudioSource source;
    public Sanity sanity;
    float maxVolume;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        maxVolume = source.volume;
    }

    // Update is called once per frame
    void Update()
    {
        source.volume = Utils.Map(sanity.sanityAmount, 0.8f, 0.3f, 0, maxVolume);

        source.volume = Mathf.Clamp(source.volume, 0, maxVolume);

        if(sanity.sanityAmount <= 0.3)
        {
            source.volume = 0f;
        }
    }
}
