using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccSliderReset : MonoBehaviour {
    public Slider aslider;

    void LateUpdate()
    {
        if (!Input.GetMouseButton(0))
        {
            if (aslider.value <= 1.5)
                aslider.value = Mathf.MoveTowards(aslider.value, -50.0f, 0.4f * aslider.value);

            else
                aslider.value = Mathf.MoveTowards(aslider.value, -50.0f, 0.08f * aslider.value);

        }

    }
}
