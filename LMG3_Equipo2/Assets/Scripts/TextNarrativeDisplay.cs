using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextNarrativeDisplay : MonoBehaviour
{
    public TMP_Text text;

    private void Awake()
    {
        text.enabled = false;
    }


    public void TriggerTextDisplay()
    {
        StartCoroutine(DisplayText());
    }

    IEnumerator DisplayText()
    {
        text.enabled = true;
        yield return new WaitForSeconds(6f);
        text.enabled = false;
    }
}
