using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDisplay : MonoBehaviour
{

    public Player player;
    public Image keyImageUI;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keyImageUI.enabled = player.hasKey;
    }
}
