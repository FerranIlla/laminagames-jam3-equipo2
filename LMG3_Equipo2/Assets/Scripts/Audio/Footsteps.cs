using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public List<AudioClip> stepClips = new List<AudioClip>();
    AudioSource source;
    public float stepsVolume = 1f;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayFootStep()
    {
        int clipToUse = Random.Range(0, stepClips.Count);

        source.clip = stepClips[clipToUse];
        source.PlayOneShot(stepClips[clipToUse], stepsVolume);
    }
}
