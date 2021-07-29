using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public AudioSource shortBeep;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFlickerSound()
    {
        shortBeep.Play();
    }

    public void StopFlickerSound()
    {
        shortBeep.Stop();
    }
}
