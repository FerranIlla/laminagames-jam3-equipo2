using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{

    Player player;
    public GameObject doorBlockCollider;
    public Animator animator;

    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (player.hasKey)
            {
                //open door
                animator.SetTrigger("OpenDoor");
                AudioManager.instance.PlaySound("OpenDoorSound");

                player.hasKey = false;
                GetComponent<BoxCollider>().enabled = false;
                doorBlockCollider.SetActive(false);
            }
            else
            {
                AudioManager.instance.PlaySound("BlockedDoorSound");
            }
        }
    }
}
