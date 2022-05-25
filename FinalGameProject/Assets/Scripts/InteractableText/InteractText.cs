using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractText : MonoBehaviour
{
    public TextMeshPro text;
    private bool showText = false;
    public Transform target;

    public void ShowText()
    {
        if (!showText)
        {
            text.gameObject.SetActive(true);
            showText = true;
            Debug.Log("Show Text");
        }
        else
        {
            text.gameObject.SetActive(false);
            showText = false;
            Debug.Log("Hide Text");
        }
    }

    void Update()
    {
        this.transform.LookAt(target);
    }
}
