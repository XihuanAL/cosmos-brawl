using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_one : MonoBehaviour
{

    GameObject playtwo;
    
    public GameObject playone;
    int fangxiang ;
    public static int force_one=10;

    // Start is called before the first frame update
    void Start()
    {
        
        playtwo = GameObject.Find("playertwo");
        playone = GameObject.Find("playerone");
        if (playone.GetComponent<Move>().chaoxiang)
        {
           
            fangxiang = -1;
            GetComponent<BoxCollider2D>().offset = new Vector2(-GetComponent<BoxCollider2D>().offset.x, GetComponent<BoxCollider2D>().offset.y);

        }
        else fangxiang = 1;  


    }

    // Update is called once per frame
    void Update()
    {
       
            if (fangxiang == -1)
        {
            transform.localScale = new Vector2(-1.1634f, 2.2237f);
        }
        if (GetComponent<Rigidbody2D>().velocity.x == 0)
        { GetComponent<Rigidbody2D>().velocity = new Vector2(20 * fangxiang, 0); }
        Destroy(gameObject, 2f);
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == playtwo)
        {
            playtwo.GetComponent<Rigidbody2D>().AddForce(new Vector2(force_one * fangxiang, 0f), ForceMode2D.Impulse);
            Destroy(gameObject);
        }
        if (other.gameObject.name != "playerone" && other.gameObject.name != "refle(Clone)" && other.gameObject.name != "Sniper_rifle(Clone)")
        {
            Destroy(gameObject);
        }
    }
  
}
