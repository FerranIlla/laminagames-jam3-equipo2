using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    /*[HideInInspector]*/ public float sanityAmount = 1f;
    public float decreasingSpeed = 5f;
    public float secondsToWaitUntilStartRecovery = 3.0f; //value to reset the timer to
    float timerRecovery;

    public Image fadeBlackImage;
    public Image fadeWhiteImage;



    private void Awake()
    {
        timerRecovery = secondsToWaitUntilStartRecovery;
        DontDestroyOnLoad(gameObject);
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


        if (sanityAmount <= 0f)
        {
            StartCoroutine(LoseGame());
        }

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

    IEnumerator LoseGame()
    {
        for (float f = 0f; f < 3f; f += Time.deltaTime)
        {
            float value = Utils.Map(f, 0f, 3f, 0f, 1f);
            fadeBlackImage.color = new Color(fadeBlackImage.color.r, fadeBlackImage.color.g, fadeBlackImage.color.b, value);
            yield return null;
        }

        SceneManager.LoadScene("GameOver");
    }

    IEnumerator WinGame()
    {
        for (float f = 0f; f < 3f; f += Time.deltaTime)
        {
            float value = Utils.Map(f, 0f, 3f, 0f, 1f);
            fadeWhiteImage.color = new Color(fadeWhiteImage.color.r, fadeWhiteImage.color.g, fadeWhiteImage.color.b, value);
            yield return null;
        }

        SceneManager.LoadScene("WinGame");
    }

    public void TiggerWinGame()
    {
        StartCoroutine(WinGame());
    }
}
