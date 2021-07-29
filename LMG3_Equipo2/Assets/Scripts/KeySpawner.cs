using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    List<Transform> possibleKeys = new List<Transform>();
    Transform keyChosen;
    int randomIndex;

    // Start is called before the first frame update
    void Awake()
    {
        if (transform.childCount <= 0)
        {
            Debug.LogWarning("there are no keys in the scene");
            return;
        }
        FillListOfPossibleKeys();
        randomIndex = Random.Range(0, possibleKeys.Count);
        keyChosen = possibleKeys[randomIndex];
        DeleteExtraKeys(randomIndex);

        PrintInfo();
    }

    void FillListOfPossibleKeys()
    {
        foreach(Transform child in transform)
        {
            possibleKeys.Add(child);
        }
    }

    void DeleteExtraKeys(int indexChosen)
    {
        for(int i = 0; i < possibleKeys.Count; i++)
        {
            if(i != indexChosen)
            {
                possibleKeys[i].gameObject.SetActive(false);
            }
        }
    }

    void PrintInfo()
    {
        Debug.Log("Selected Key number " + (randomIndex+1));
    }
}
