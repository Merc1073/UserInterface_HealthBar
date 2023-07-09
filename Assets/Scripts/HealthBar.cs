using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{


    public Slider healthSlider;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            healthSlider.value -= 5f;
        }

        else if(Input.GetKeyDown(KeyCode.T))
        {
            healthSlider.value += 20f;
        }
    }
}
