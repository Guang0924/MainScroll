using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScroll : MonoBehaviour
{
    public CanvasGroup subCG;   //Canvas Group on Sub Scroll
    Vector2 inputDown;
    bool active;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            inputDown = Input.mousePosition;
            active = true;
        }

        if (active)
        {
            if (Mathf.Abs(inputDown.x - Input.mousePosition.x) > 1f)
            {
                active = false;
                subCG.blocksRaycasts = false;
            }

            if (Mathf.Abs(inputDown.y - Input.mousePosition.y) > 1f)
            {
                active = false;
                subCG.blocksRaycasts = true;
            }
        }
    }
}
