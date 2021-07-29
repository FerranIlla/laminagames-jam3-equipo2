using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditsBack : MonoBehaviour
{

    public MainMenuButtons buttonsScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            buttonsScript.BackButtonPressed();
        }
    }
}
