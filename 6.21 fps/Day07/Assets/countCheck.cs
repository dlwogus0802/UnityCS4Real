using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class countCheck : MonoBehaviour
{
    public Text CountText;
    public Text DirectText;
    public GameObject btn;
    private int getCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        getCount = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("UP"))
        {
            DirectText.text = "Down!";
        }
        else if(other.gameObject.CompareTag("DOWN"))
        {
            if (DirectText.text == "Down!") getCount++;
            DirectText.text = "UP!";
            //getCount++;
        }
        else if (other.gameObject.CompareTag("LEFT"))
        {
            if (DirectText.text == "LEFT!") getCount++;
            DirectText.text = "RIGHT!";
            
        }
        else if (other.gameObject.CompareTag("RIGHT"))
        {
            DirectText.text = "LEFT!";
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (getCount == 10) btn.gameObject.SetActive(true);
        if (getCount < 10) CountText.text = getCount.ToString();
        else
        {
            CountText.text = "<color=#0000ff>"+"OK!" + "</color>";
        }
    }
}
