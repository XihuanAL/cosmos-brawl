using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class group_one : MonoBehaviour
{
    public static bool iseat;
    public static bool isrun;
    public static bool iswuqi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Eat(bool Select)
    {
        if (Select)
        {
            iseat = true;
            isrun = false;
            iswuqi = false;
        }
        
    }
    public void Run(bool Select)
    {
        if (Select)
        {
            iseat = false;
            isrun = true;
            iswuqi = false;
        }
       
    }
    public void Weap(bool Select)
    {
        if (Select)
        {
            iseat = false;
            isrun = false;
            iswuqi = true;
        }
       
    }
}
