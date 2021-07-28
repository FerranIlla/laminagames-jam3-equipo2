using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCanvas : MonoBehaviour
{
    Player player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            player.canMove = true;
            gameObject.SetActive(false);
        }
    }
}
