using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class choosescene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void star()
    {
        SceneManager.LoadScene("star");
    }
    public void forest()
    {
        SceneManager.LoadScene("forest");
    }
}
