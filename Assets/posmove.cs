using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posmove : MonoBehaviour
{
    public GameObject playerone;
    public GameObject playertwo;
    float x;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = (playerone.transform.position.x + playertwo.transform.position.x) / 2;
        y = (playerone.transform.position.y + playertwo.transform.position.y) / 2;
        transform.position = new Vector3(x, y, -10);
        if(transform.position.y> 0.1209767)
        {
            transform.position = new Vector3(transform.position.x, 0.1209767f, -10);
        }
        if (transform.position.y < -4.08901)
        {
            transform.position = new Vector3(transform.position.x, -4.08901f, -10);
        }
        if(transform.position.x< -4.86237)
        {
            transform.position = new Vector3(-4.86237f, transform.position.y, -10);
        }
        if (transform.position.x > 12.34)
        {
            transform.position = new Vector3(12.34f, transform.position.y, -10);
        }
        if (playerone.transform.position.x - playertwo.transform.position.x<12) gameObject.GetComponent<Camera>().orthographicSize=5;
        if(Mathf.Abs(playerone.transform.position.x - playertwo.transform.position.x) > 12)
        {
            gameObject.GetComponent<Camera>().orthographicSize = 5+ (Mathf.Abs(playerone.transform.position.x - playertwo.transform.position.x)-12)/2.0f;
        }
        if (gameObject.GetComponent<Camera>().orthographicSize > 8)
        {
            gameObject.GetComponent<Camera>().orthographicSize = 8;
        }
    }
}
