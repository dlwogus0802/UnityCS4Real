using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class countCheck : MonoBehaviour
{
    public Text CountText;
    public GameObject btn;
    private int getCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        getCount = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        getCount++;
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
