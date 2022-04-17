using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufomove : MonoBehaviour
{
    public float movespeed=10f;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        
        if (time < 0)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed * Random.Range(1f, 10f), movespeed * Random.Range(1f, 10f));
            gameObject.transform.position = new Vector3(-1002f,Random.Range(-1200f,-200f),0f);
            time = 10f;
        }
    }
}
