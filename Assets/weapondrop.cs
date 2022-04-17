using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapondrop : MonoBehaviour
{
    public GameObject refle;
    public GameObject Sniper_rifle;
    GameObject re;
    GameObject sn;
    public float CreatTime;
    // Start is called before the first frame update
    void Start()
    {
        CreatTime = Random.Range(10f, 15f);
    }

    // Update is called once per frame
    void Update()
    {
        re= GameObject.Find("refle(Clone)");
        sn = GameObject.Find("Sniper_rifle(Clone)");
        CreatTime -= Time.deltaTime;
        if (CreatTime < 0&& re == null&&sn==null)
        {
            if (Random.value > 0.5f)
            {
                GameObject clone = Instantiate(refle, new Vector3(Random.Range(-4f, 15f), 6f, 0f), transform.rotation) as GameObject;
            }
            else 
            { 
                GameObject clone = Instantiate(Sniper_rifle, new Vector3(Random.Range(-4f, 15f), 6f, 0f), transform.rotation) as GameObject; 
            }

        }
    }
}
