using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Rotator : MonoBehaviour
{
    public Vector3 rotationVec;
    public bool rotate = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            transform.Rotate(rotationVec * Time.deltaTime);

        }
    }
}
