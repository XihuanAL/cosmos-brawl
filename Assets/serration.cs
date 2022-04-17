using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0,0,-5f/2);
        transform.Translate(Vector2.right*0.04f/2,Space.World);
        Destroy(gameObject, 20f);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "playerone")
        {
            Move.isdied = true;
        }
        if (other.gameObject.name =="playertwo")
        {
            Movetwo.isdied = true;

        }
    }
    
}
