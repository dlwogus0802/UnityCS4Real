using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texttest : MonoBehaviour
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
        float t = tr.eulerAngles.x;
        if (t > 180 && t < 360) t = t - 360;
        angleText.text = t.ToString("F1");
    }
}
