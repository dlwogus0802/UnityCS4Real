using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void SceneChange()
    {
        string objectName = transform.parent.tag;
        if(tag == "stage1")
        {
            SceneManager.LoadScene("Projects/IMU/IMU");
        }
        else if(tag == "stage2")
        {
            SceneManager.LoadScene("IMU2");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
