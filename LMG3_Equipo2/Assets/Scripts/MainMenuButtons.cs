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
    bool cruzetaUp = true;

    public GameObject selectIndicator;
    public GameObject backIndicator;

    private void Awake()
    {
        buttonsCanvas = gameObject;

        greenColor = option0.GetComponent<Image>().color;
        selectIndicator.SetActive(true);
        backIndicator.SetActive(false);
    }

    private void Update()
    {
        //Input
        float downAxisValue = Input.GetAxisRaw("Vertical Dpad");
        float verticalAxisValue = Input.GetAxisRaw("Vertical");

        if ((downAxisValue > 0 || verticalAxisValue>0) && cruzetaUp)
        {
            UpInput();
            cruzetaUp = false;
        }
        if ((downAxisValue < 0 || verticalAxisValue <0)&& cruzetaUp)
        {
            DownInput();
            cruzetaUp = false;
        }
        if (downAxisValue == 0 && verticalAxisValue == 0) cruzetaUp = true;
        
        PaintAllGreen();
        PaintSelectedWhite();
        
        //select
        if (Input.GetButtonDown("Submit")) SelectInput();

    }

    public void StartButtonPressed(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void CreditsButtonPressed()
    {
        //Hide buttons
        buttonsCanvas.SetActive(false);
        selectIndicator.SetActive(false);

        //Show credits
        creditsCanvas.SetActive(true);
        backIndicator.SetActive(true);
    }

    public void BackButtonPressed()
    {
        //Hide credits
        creditsCanvas.SetActive(false);
        backIndicator.SetActive(false);

        //Show buttons
        buttonsCanvas.SetActive(true);
        selectIndicator.SetActive(true);
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
