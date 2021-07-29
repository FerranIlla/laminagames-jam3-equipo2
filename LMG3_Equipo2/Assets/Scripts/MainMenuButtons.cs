using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject creditsCanvas;
    private GameObject buttonsCanvas;

    int menuOptionIndex = 0;
    public GameObject option0, option1, option2;

    Color greenColor;

    private void Awake()
    {
        buttonsCanvas = gameObject;

        greenColor = option0.GetComponent<Image>().color;
    }

    private void Update()
    {
        //Input
        if (Input.GetKeyDown(KeyCode.DownArrow)) DownInput();
        if (Input.GetKeyDown(KeyCode.UpArrow)) UpInput();
        PaintAllGreen();
        PaintSelectedWhite();


        //select
        if (Input.GetKeyDown(KeyCode.Space)) SelectInput();

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

    public void DownInput()
    {
        menuOptionIndex++;
        menuOptionIndex = Mathf.Clamp(menuOptionIndex, 0, 2);
    }
    public void UpInput()
    {
        menuOptionIndex--;
        menuOptionIndex = Mathf.Clamp(menuOptionIndex, 0, 2);
    }

    void PaintAllGreen()
    {
        option0.GetComponent<Image>().color = greenColor;
        option1.GetComponent<Image>().color = greenColor;
        option2.GetComponent<Image>().color = greenColor;
    }

    void PaintSelectedWhite()
    {
        if(menuOptionIndex == 0) option0.GetComponent<Image>().color = Color.white;
        if (menuOptionIndex == 1) option1.GetComponent<Image>().color = Color.white;
        if (menuOptionIndex == 2) option2.GetComponent<Image>().color = Color.white;
    }

    public void SelectInput()
    {
        if (menuOptionIndex == 0) StartButtonPressed("Blocking");
        if (menuOptionIndex == 1) CreditsButtonPressed();
        if (menuOptionIndex == 2) ExitButtonPressed();
    }

}
