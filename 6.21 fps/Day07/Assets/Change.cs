using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Change : MonoBehaviour
{
    private static bool btn1 = false;
    private static bool btn2 = false;
    private static bool btn3 = false;
    private static bool btn4 = false;
    public Slider percentBar;
    public void SceneChange()
    {
        string objectName = transform.parent.tag;
        if(tag == "stage1")
        {
            SceneManager.LoadScene("Projects/IMU/IMU");
            btn1 = true;
            
        }
        else if(tag == "stage2")
        {
            SceneManager.LoadScene("IMU2");
            btn2 = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "stage1" && btn1)
        {
            gameObject.SetActive(false);
        }
        if (tag == "stage2" && btn2)
        {
            gameObject.SetActive(false);
        }

    }
}
