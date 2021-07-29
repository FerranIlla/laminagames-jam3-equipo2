using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverSceneManager : MonoBehaviour
{

    float waitTime = 0f;
    public TMP_Text returnText;

    // Start is called before the first frame update
    void Awake()
    {
        returnText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime >= 3f)
        {
            returnText.enabled = true;
            if (Input.GetButtonDown("Jump"))
            {
                SceneManager.LoadScene("MainMenu");
                Destroy(GameObject.FindWithTag("Player"));
            }
        }
        waitTime += Time.deltaTime;
    }
}
