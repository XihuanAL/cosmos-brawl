using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sniper_rifle : MonoBehaviour
{
    GameObject weap_drop;
    GameObject pone;
    GameObject ptwo;
    GameObject pone_;
    GameObject ptwo_;
    Sprite sn;
    AudioClip sniper;
    //GameObject ponebullet;
    //GameObject ptwobullet;
    // Start is called before the first frame update
    private void Start()
    {
        weap_drop = GameObject.Find("Weapon drop ");
        pone = GameObject.Find("playerone");
        ptwo = GameObject.Find("playertwo");
        pone_ = GameObject.Find("weap_one");
        ptwo_ = GameObject.Find("weap_two");
        //ptwobullet_two = GameObject.Find("bullet_Sprite 1(Clone)");
        //ponebullet_two = GameObject.Find("bullet_Sprite(Clone)");
        sn = Resources.Load<Sprite>("sniper2");
        sniper = Resources.Load<AudioClip>("狙击枪(改");
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
            pone.GetComponent<Move>().fireRate = 0.75f;
            //ponebullet.GetComponent<bullet_one>().force= 20;
            weap_drop.GetComponent<weapondrop>().CreatTime = Random.Range(10f, 15f);
            bullet_one.force_one = 15;
            pone_.GetComponent<SpriteRenderer>().sprite = sn;
            pone.GetComponent<AudioSource>().clip = sniper;
        }
        if (other.gameObject.name == "playertwo")
        {
            Destroy(gameObject);
            ptwo.GetComponent<Movetwo>().fireRate = 0.75f;
            
            weap_drop.GetComponent<weapondrop>().CreatTime = Random.Range(10f, 15f);
            bullet_two.force_two = 15;
            ptwo_.GetComponent<SpriteRenderer>().sprite = sn;
            ptwo.GetComponent<AudioSource>().clip = sniper;
        }
    }
}
