using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public bool bGameScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bGameScene)
        {
            SceneManager.LoadScene("choose");
        }
    }
    public void StartBtn()
    {
        bGameScene = true;
    }
}
