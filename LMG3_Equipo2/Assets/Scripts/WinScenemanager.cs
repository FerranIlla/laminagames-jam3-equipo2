using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScenemanager : MonoBehaviour
{
    float waitTime = 0f;
    public GameObject returnText;

    // Start is called before the first frame update
    void Awake()
    {
        returnText.SetActive(false);
        Destroy(GameObject.FindWithTag("Player"));
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime >= 3f)
        {
            returnText.SetActive(true);
            if (Input.GetButtonDown("Submit") || Input.GetButtonDown("Cancel"))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        waitTime += Time.deltaTime;
    }
}
