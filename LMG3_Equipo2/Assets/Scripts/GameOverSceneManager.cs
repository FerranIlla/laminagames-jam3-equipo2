using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverSceneManager : MonoBehaviour
{

    float waitTime = 0f;
    public GameObject returnText;

    // Start is called before the first frame update
    void Awake()
    {
        returnText.SetActive(false);
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
                Destroy(GameObject.FindWithTag("Player"));
            }
        }
        waitTime += Time.deltaTime;
    }
}
