using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class plus_percent : MonoBehaviour
{
    public Slider percentBar;
    private static float num = 0.0f;
    private static float num2 = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        float number = 0;
        percentBar.value = number;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (num2 < num) {
            num2 += 0.01f;
            percentBar.value += 0.01f;
        }
        */
        //if (percentBar.value < Mathf.Round((float)num)) percentBar.value += 0.1f;
    }

    public void click_button()
    {
        num += 0.5f;
    }
}
