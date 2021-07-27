using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityDisplay : MonoBehaviour
{
    public Sanity playerSanity;
    public RectTransform sanityBar;
    float maxHeightBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHeightBar = sanityBar.sizeDelta.y;
        sanityBar.sizeDelta = new Vector2(sanityBar.sizeDelta.x, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        DrawSanityBar();
    }

    private void DrawSanityBar()
    {
        float value = 1 - playerSanity.sanityAmount;

        sanityBar.sizeDelta = new Vector2(sanityBar.sizeDelta.x, maxHeightBar * value);
    }
}
