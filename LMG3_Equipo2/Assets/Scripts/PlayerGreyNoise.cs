using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGreyNoise : MonoBehaviour
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
        source.volume = Utils.Map(sanity.sanityAmount, 0.6f, 0f, 0, maxVolume);

        source.volume = Mathf.Clamp(source.volume, 0, maxVolume);

    }
}
