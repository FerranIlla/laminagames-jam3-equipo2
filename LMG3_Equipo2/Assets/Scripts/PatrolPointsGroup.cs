using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolPointsGroup : MonoBehaviour
{
    [HideInInspector] public List<PatrolPoint> points = new List<PatrolPoint>();

    // Start is called before the first frame update
    void Awake()
    {
        FillPointslist();
    }

    void FillPointslist()
    {
        foreach(Transform child in transform)
        {
            points.Add(child.GetComponent<PatrolPoint>());
        }
    }
}
