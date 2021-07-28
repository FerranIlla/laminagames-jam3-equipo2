using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    Player player;
    public float rangeDebug;

    void Awake()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInRange())
        {
            //grab key
            player.KeyFound();
            Destroy(gameObject);
        }
    }

    bool PlayerInRange()
    {
        float range = 1.5f;
        Vector2 playerHorizontalPos = new Vector2(player.transform.position.x, player.transform.position.z);
        Vector2 keyHorizontalPos = new Vector2(transform.position.x, transform.position.z);
        rangeDebug = Vector2.Distance(playerHorizontalPos, keyHorizontalPos);
        if (Vector2.Distance(playerHorizontalPos, keyHorizontalPos) < range)
        {
            return true;
        }

        return false;
    }
}
