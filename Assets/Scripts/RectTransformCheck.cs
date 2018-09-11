using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class RectTransformCheck : MonoBehaviour
{
    private RectTransform buttonRect;
    private Vector3 localPos;
    private Vector2 sizeDelta;
    private bool toggle = false;

	// Use this for initialization
	void Awake ()
    {
        buttonRect = GetComponent<RectTransform>();
        localPos = buttonRect.localPosition;
        sizeDelta = buttonRect.sizeDelta;

        InvokeRepeating("DiminishRect", 1.0f, 2.0f);
	}

    void DiminishRect()
    {
        if(toggle)
        {
            buttonRect.localPosition = new Vector3(0, 0, 0);
            buttonRect.sizeDelta = new Vector2(0, 0);
        }
        else
        {
            buttonRect.localPosition = localPos;
            buttonRect.sizeDelta = sizeDelta;
        }
        toggle = !toggle;
    }
}
