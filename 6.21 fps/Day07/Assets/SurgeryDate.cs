using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class SurgeryDate : MonoBehaviour
{
    [SerializeField] Text today1;
    private static DateTime surgeryD = DateTime.Now;
    public GameObject btn1;
    public GameObject btn2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        today1.text = surgeryD.ToString("yyyy-MM-dd");
    }

    public void AddDate()
    {
        surgeryD = surgeryD.AddDays(1);
        TimeSpan timeDif = DateTime.Now - surgeryD;
        if (timeDif.Days > 0 && timeDif.Days <= 7)
        {
            btn1.SetActive(true);
            btn2.SetActive(false);
        } else if(timeDif.Days >7 && timeDif.Days <= 14)
        {
            btn2.SetActive(true);
            btn1.SetActive(false);
        }
        else
        {
            btn2.SetActive(false);
            btn1.SetActive(false);
        }
    }
    public void SubDate()
    {
        surgeryD = surgeryD.AddDays(-1);
        TimeSpan timeDif = DateTime.Now - surgeryD;
        if (timeDif.Days > 0 && timeDif.Days <= 7)
        {
            btn1.SetActive(true);
            btn2.SetActive(false);
        }
        else if (timeDif.Days > 7 && timeDif.Days <= 14)
        {
            btn2.SetActive(true);
            btn1.SetActive(false);
        }
        else
        {
            btn2.SetActive(false);
            btn1.SetActive(false);
        }
    }
}
