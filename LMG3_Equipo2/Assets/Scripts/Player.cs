using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasKey = false;
    [SerializeField] private GameObject keyCanvas;
    public bool canMove = true;

    public void KeyFound()
    {
        hasKey = true;
        keyCanvas.SetActive(true);
        canMove = false;
    }
}
