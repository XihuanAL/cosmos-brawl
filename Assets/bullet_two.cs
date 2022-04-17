using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_two : MonoBehaviour
{
    
    GameObject playone;
    
    public GameObject playtwo;
    int fangxiang;
    [SerializeField]
    public static int force_two=10;
    // Start is called before the first frame update
    void Start()
    {
       
        playtwo = GameObject.Find("playertwo");
        playone = GameObject.Find("playerone");
        if (playtwo.GetComponent<Movetwo>().chaoxiang )
        {

            fangxiang = -1;
            GetComponent<BoxCollider2D>().offset = new Vector2(-GetComponent<BoxCollider2D>().offset.x, GetComponent<BoxCollider2D>().offset.y);
        }
        else  fangxiang = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        //fangxiang = playtwo.GetComponent<Movetwo>().xVelocity > 0 ? 1 : -1;
       
        //if (!playtwo.GetComponent<Movetwo>().chaoxiang)
        //{
        //fangxiang = -1;
        //}

        if (fangxiang == -1)
        {
            transform.localScale=new Vector2(-1.1634f, 2.2237f);
        }
        if (GetComponent<Rigidbody2D>().velocity.x == 0)
        { GetComponent<Rigidbody2D>().velocity = new Vector2(20 * fangxiang, 0); }
        Destroy(gameObject, 2f);
    }
  
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == playone)
        {
            playone.GetComponent<Rigidbody2D>().AddForce(new Vector2(force_two * fangxiang, 0f), ForceMode2D.Impulse);
        }
        if (other.gameObject.name != "playertwo" && other.gameObject.name != "refle(Clone)" && other.gameObject.name != "Sniper_rifle(Clone)")
        {
            Destroy(gameObject);

        }
    }
   
    

}
