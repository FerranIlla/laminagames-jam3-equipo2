using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject creditsCanvas;
    private GameObject buttonsCanvas;

    private void Awake()
    {
        buttonsCanvas = gameObject;
    }

    public void StartButtonPressed(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CreditsButtonPressed()
    {
        //Hide buttons
        buttonsCanvas.SetActive(false);

        //Show credits
        creditsCanvas.SetActive(true);
    }

    public void BackButtonPressed()
    {
        //Hide credits
        creditsCanvas.SetActive(false);

        //Show buttons
        buttonsCanvas.SetActive(true);
    }

    public void ExitButtonPressed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
