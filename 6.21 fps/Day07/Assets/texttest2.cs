using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texttest2 : MonoBehaviour
{
    public Text angleText;
    public GameObject cur;
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = cur.GetComponent < RectTransform >();
    }

    // Update is called once per frame
    void Update()
    {
        float t = 360 - tr.eulerAngles.y;
        //t = 180 - t;
        //if (t > 180 && t < 360) t = t - 360;
        //angleText.text = t.ToString("F1");
        if (t >= 300) t = 0;
        if (angleText.text == "RIGHT!")
        {
            angleText.fontSize = Mathf.RoundToInt(15 + (t) * 0.15f);
        }
        else
        {
            angleText.fontSize = Mathf.RoundToInt(15 + (90-t) * 0.15f);
        }
    }
}
