using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public CharacterController controller;
    public float speed = 12f;
    Player p;

    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        p = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (p.canMove)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);
        }
    }

    public bool IsMoving()
    {
        return controller.velocity != Vector3.zero;
    }
}
