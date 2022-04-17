using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reflepickup : MonoBehaviour
{
    GameObject weap_drop;
    GameObject pone;
    GameObject ptwo;
    GameObject pone_;
    GameObject ptwo_;
    Sprite re;
    AudioClip refle;
    // Start is called before the first frame update
    private void Start()
    {
        weap_drop = GameObject.Find("Weapon drop ");
        pone = GameObject.Find("playerone");
        ptwo = GameObject.Find("playertwo");
        pone_ = GameObject.Find("weap_one");
        ptwo_ = GameObject.Find("weap_two");
        re= Resources.Load<Sprite>("smg2");
        refle = Resources.Load<AudioClip>("冲锋枪（改");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "playerone")
        {
            Destroy(gameObject);
            pone.GetComponent<Move>().fireRate = 0.2f;
            weap_drop.GetComponent<weapondrop>().CreatTime = Random.Range(10f, 15f);
            bullet_one.force_one = 10;
            pone_.GetComponent<SpriteRenderer>().sprite = re;
            pone.GetComponent<AudioSource>().clip = refle;
        }
        if (other.gameObject.name == "playertwo")
        {
            Destroy(gameObject);
            ptwo.GetComponent<Movetwo>().fireRate = 0.2f;
            weap_drop.GetComponent<weapondrop>().CreatTime=Random.Range(10f, 15f);
            bullet_two.force_two = 10;
            ptwo_.GetComponent<SpriteRenderer>().sprite = re;
            ptwo.GetComponent<AudioSource>().clip = refle;
        }
    }
}
