using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serration_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, -5f / 2);
        transform.Translate(Vector2.right * 0.04f / 2, Space.World);
        Destroy(gameObject, 20f);
    }
    // Update is called once per frame
   
}
