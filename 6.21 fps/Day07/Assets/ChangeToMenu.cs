using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeToMenu : MonoBehaviour
{
    public void SceneChange()
    {
        string objectName = transform.parent.tag;
        SceneManager.LoadScene("ReadyExercise");
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
