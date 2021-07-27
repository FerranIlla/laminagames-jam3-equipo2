using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPoint : MonoBehaviour
{
    [HideInInspector] public Vector3 positionOnFloor;
    [SerializeField] private GameObject debugSphereOnFloor;

    // Start is called before the first frame update
    void Awake()
    {
        CalculatePositionOnFloor();
        InstantiateDebugSphereOnFloor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CalculatePositionOnFloor()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, Mathf.Infinity, LayerMask.GetMask("Floor")))
        {
            positionOnFloor = hit.point;
        }
        else
        {
            Debug.Log("A PatrolPoint can't find a floor under it");
            return;
        }
    }

    private void InstantiateDebugSphereOnFloor()
    {
        if(positionOnFloor != null)
        {
            Instantiate(debugSphereOnFloor, positionOnFloor, Quaternion.identity, transform);
        }
    }
}
