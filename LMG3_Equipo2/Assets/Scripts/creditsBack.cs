using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditsBack : MonoBehaviour
{

    public MainMenuButtons buttonsScript;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            buttonsScript.BackButtonPressed();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            buttonsScript.BackButtonPressed();
        }
    }
}
