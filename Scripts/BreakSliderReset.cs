using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakSliderReset : MonoBehaviour
{
    public Slider bslider;
    
    void LateUpdate()
    {
        if (!Input.GetMouseButton(0))
        {
            if (bslider.value <= 1.5)
                bslider.value = Mathf.MoveTowards(bslider.value, -50.0f, 0.5f * bslider.value);

            else
                bslider.value = Mathf.MoveTowards(bslider.value, -50.0f, 0.1f * bslider.value);

        }

    }
}
