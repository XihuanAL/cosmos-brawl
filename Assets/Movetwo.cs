using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movetwo : MonoBehaviour
{
    public new AudioSource audio;
    AudioClip shousheng;
    Animator anim;
    //角色移动
    public int speed = 4;
    Rigidbody2D pl;
    public float xVelocity;
    bool jump=false;
    public bool chaoxiang;
    public bool isOnground;
    public bool isOnplayer;
    public bool isOnjuchi;
    public LayerMask groundLayer;
    public LayerMask playerLayer;
    public LayerMask juchi;
    float footOffset = 0.15f;
    float groundDistance = 0.05f;
    GameObject ptwo;
    public static bool isdied;
    public  float mass;
    public  float movespeed;
    public  bool isdashi;
    GameObject text;
    Sprite shou;
    GameObject zi;

    //子弹发射
    public GameObject bullet_Sprite_right;
    //public GameObject bullet_Sprite_left;
    public float fireRate = 0.5f;
    float nextFire = 0f;

    //生命值
    public int hp = 5;



    void Start()
    {
        shousheng = Resources.Load<AudioClip>("手枪1");
        audio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        zi = GameObject.Find("weap_two");
        shou = Resources.Load<Sprite>("pistol2");
        text = GameObject.Find("Text_two");
        if (group_two.iseat)
        {
            mass = 1.4f;
        }
        else mass = 1f;
        if (group_two.isrun)
        {
            movespeed = 0.1f/2;
        }
        else movespeed = 0.075f/2;
        if (group_two.iswuqi)
        {
            isdashi = true;
        }
        else isdashi = false;
        ptwo = GameObject.Find("playertwo");
        //Vector3 chushipos = new Vector3();
        //transform.Translate(UnityEngine.Random.Range(-2.5f,4.0f),6,0);
        pl =GetComponent<Rigidbody2D>();
        pl.position = new Vector2(11.1f, 6f);
        pl.velocity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Flipplayer();
        gameObject.GetComponent<Rigidbody2D>().mass = mass;
        jump = Input.GetButton("jumptwo");
        Vector3 play_right = new Vector3(transform.position.x - footOffset-0.01f, transform.position.y + 0.45f, transform.position.z);
        Vector3 play_left = new Vector3(transform.position.x + footOffset+0.01f, transform.position.y + 0.45f, transform.position.z);
        //Vector3 play_left = new Vector3(transform.position.x, transform.position.y + 0.45f, transform.position.z);

        xVelocity = Input.GetAxis("horizontaltwo");
        anim.SetFloat("Vx", Mathf.Abs(xVelocity));
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            audio.Play();
            if (chaoxiang)
            {
                GameObject clone = Instantiate(bullet_Sprite_right, play_left, transform.rotation) as GameObject;
            }
            else
            {
                GameObject clone = Instantiate(bullet_Sprite_right, play_right, transform.rotation) as GameObject;
            }

        }
        if (hp == 0)
        {
            SceneManager.LoadScene("onewin");
        }

        text.GetComponent<Text>().text = ("✖" + hp);


    }
    private void FixedUpdate()
    {
        PhysicsCheck();
        //pl.velocity = new Vector2(xVelocity * speed, pl.velocity.y);
        
            if (xVelocity > 0) pl.position = new Vector2(pl.position.x + movespeed, pl.position.y);
            if (xVelocity < 0) pl.position = new Vector2(pl.position.x - movespeed, pl.position.y);
        




        if (jump && ((isOnground||isOnplayer)||isOnjuchi))
        {
            anim.SetBool("isjump", true);
            pl.velocity = new Vector2(pl.velocity.x, 9f);
            isOnground = false;
        }
        if (transform.position.y < -10f||isdied==true)
        {
            pl.position = new Vector2(Random.Range(-2.5f, 14.0f), 6f);
            pl.velocity = new Vector2(0, 0);
            if (!isdashi) 
            {
                ptwo.GetComponent<Movetwo>().fireRate = 0.5f;
                bullet_two.force_two = 10;
                zi.GetComponent<SpriteRenderer>().sprite = shou;
                audio.clip = shousheng;
            }
            
            hp--;
            isdied = false;
        }

    }
    void PhysicsCheck()
    {
        //Vector2 pos = transform.position;
        //Vector2 offset = new Vector2(-footOffset, 0f);

        //RaycastHit2D leftCheck = Physics2D.Raycast(pos + offset, Vector2.down, groundDistance, groundLayer);


        RaycastHit2D leftCheck = Raycast(new Vector2(-footOffset, 0f), Vector2.down, groundDistance, groundLayer);
        RaycastHit2D rightCheck = Raycast(new Vector2(footOffset, 0f), Vector2.down, groundDistance, groundLayer);
        RaycastHit2D leftCheckplayer = Raycast(new Vector2(-footOffset, 0f), Vector2.down, groundDistance, playerLayer);
        RaycastHit2D rightCheckplayer = Raycast(new Vector2(footOffset, 0f), Vector2.down, groundDistance, playerLayer);
        RaycastHit2D leftCheckjuchi = Raycast(new Vector2(-footOffset, 0f), Vector2.down, groundDistance, juchi);
        RaycastHit2D rightCheckjuchi = Raycast(new Vector2(footOffset, 0f), Vector2.down, groundDistance, juchi);

        // Debug.DrawRay(pos + offset, Vector2.down, Color.red, 0.01f);
        if (leftCheck|| rightCheck)
        {
            isOnground = true;
            anim.SetBool("isjump", false);
        }
        else isOnground = false;
        if (leftCheckplayer || rightCheckplayer)
        {
            isOnplayer = true;
            anim.SetBool("isjump", false);
        }
        else isOnplayer = false;
        if (leftCheckjuchi || rightCheckjuchi)
        {
            isOnjuchi = true;
            anim.SetBool("isjump", false);
        }
        else isOnjuchi = false;
    }
    void Flipplayer()
    {
        if (xVelocity > 0)
        {
            transform.localScale = new Vector2(0.2f, 0.2f);
            chaoxiang = false;
        }


        else if (xVelocity < 0)
        {
            transform.localScale = new Vector2(-0.2f, 0.2f);
            chaoxiang = true;

        }
    }

    RaycastHit2D Raycast(Vector2 offset, Vector2 rayDiraction, float length, LayerMask layer)
    {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(pos + offset, rayDiraction, length, layer);
        Debug.DrawRay(pos + offset, rayDiraction * length);

        return hit;
    }
   
}
