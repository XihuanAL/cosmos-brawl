using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Sprite te;
    // Start is called before the first frame update
    void Start()
    {
        te = Resources.Load<Sprite>("Box_02");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = te;
    }
}
