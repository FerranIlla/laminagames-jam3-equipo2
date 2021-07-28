using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed;
    public float timeToWaitUntilMove;
    private float timer;
    bool rotatingRight = true;

    private enum CamState { stop, move }
    private CamState state = CamState.stop;

    [Range(0f, 360f)]
    public float maxRotation;
    private float currentRotation = 0f;


    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (state == CamState.stop)
        {
            timer += Time.deltaTime;
            if (timer >= timeToWaitUntilMove)
            {
                //start rotation
                state = CamState.move;
                timer = 0f;
            }
        }
        else //state == CamState.move
        {
            if (rotatingRight)
            {
                transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0), Space.World);
                currentRotation += rotationSpeed * Time.deltaTime;
                if (currentRotation > maxRotation)
                {
                    rotatingRight = false;
                    state = CamState.stop;
                    currentRotation = 0f;
                }
            }
            else
            {
                transform.Rotate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0), Space.World);
                currentRotation += rotationSpeed * Time.deltaTime;
                if (currentRotation > maxRotation)
                {
                    rotatingRight = true;
                    state = CamState.stop;
                    currentRotation = 0f;
                }
            }
        }

    }
}
