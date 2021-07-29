using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goteo : MonoBehaviour
{

    private Sanity playerSanity;
    public float minDistToAffect;
    public float maxSanityImpact;

    public float currentDistance;

    void Awake()
    {
        playerSanity = GameObject.FindWithTag("Player").GetComponent<Sanity>();
    }

    // Update is called once per frame
    void Update()
    {
        //calculate distance with player
        float distanceWithPlayer = Vector3.Distance(transform.position, playerSanity.transform.position);
        currentDistance = distanceWithPlayer;

        if (distanceWithPlayer < minDistToAffect)
        {
            //sanity impact by distance
            float impactValue = Utils.Map(distanceWithPlayer, minDistToAffect, 0, 0, maxSanityImpact);
            playerSanity.SanityImpact(impactValue * Time.deltaTime);
        }
    }
}
