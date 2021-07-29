using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScenemanager : MonoBehaviour
{
    float waitTime = 0f;
    public TMP_Text returnText;

    // Start is called before the first frame update
    void Awake()
    {
        returnText.enabled = false;
        Destroy(GameObject.FindWithTag("Player"));
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
            }
        }
        waitTime += Time.deltaTime;
    }
}
