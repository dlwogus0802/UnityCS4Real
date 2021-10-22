using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TodayDate : MonoBehaviour
{
    [SerializeField] Text today1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        today1.text = DateTime.Now.ToString("yyyy-MM-dd");
    }
}
