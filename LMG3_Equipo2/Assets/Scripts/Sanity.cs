using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sanity : MonoBehaviour
{
    /*[HideInInspector]*/ public float sanityAmount = 1f;
    public float decreasingSpeed = 5f;
    public float secondsToWaitUntilStartRecovery = 3.0f; //value to reset the timer to
    float timerRecovery;

    private void Awake()
    {
        timerRecovery = secondsToWaitUntilStartRecovery;
    }

    private void Update()
    {
        ////debug imact
        //if (Input.GetButtonDown("Jump"))
        //{
        //    SanityImpact(0.1f);
        //}

        if(timerRecovery < 0)
        {
            DecreaseCrazynessOverTime();
        }
        timerRecovery -= Time.deltaTime;



        //clamp Sanity Value
        sanityAmount = Mathf.Clamp01(sanityAmount);
    }

    public void SanityImpact(float amount)
    {
        if (amount > 1f || amount < 0) Debug.Log("Trying to add an invalid Sanity Impact");

        sanityAmount -= amount;
        sanityAmount = Mathf.Clamp01(sanityAmount);

        timerRecovery = secondsToWaitUntilStartRecovery;
    }

    void DecreaseCrazynessOverTime()
    {
        sanityAmount += decreasingSpeed * Time.deltaTime;
    }
}
