using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_choose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void start()
    {
        if (group_one.iseat) print("1eat");
        if (group_one.isrun) print("1run");
        if (group_one.iswuqi) print("1wuqi");
        if (group_two.iseat) print("2eat");
        if (group_two.isrun) print("2run");
        if (group_two.iswuqi) print("2wuqi");
        SceneManager.LoadScene("choosescene");

    }
}
