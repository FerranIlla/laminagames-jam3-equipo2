using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimations : MonoBehaviour
{
    public Animator walkShake;
    public Animator sanityShake;
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //idle-walk respiration shake
        walkShake.SetBool("isWalking", playerMovement.IsMoving());
    }

    
}
