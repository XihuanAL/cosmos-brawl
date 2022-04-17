using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    public float CreatTime;
    public GameObject Spike_01;
    // Start is called before the first frame update
    void Start()
    {
        CreatTime = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        CreatTime -= Time.deltaTime;
        if (CreatTime < 0)
        {
            GameObject clone = Instantiate(Spike_01, new Vector3(-13, Random.Range(-3.5f, 1f), 0f), transform.rotation) as GameObject;
            CreatTime = 25f;
        }
    }
}
