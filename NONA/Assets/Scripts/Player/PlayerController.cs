using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float jump1 = 10.0f;
    public float jump2 = 12.0f;
    //public  bool inputJump = false; //점프키를 누를때 활성화
    public int dashCount = 1;
    //public int extraJumps;
   //public int extraJumpsValue;


    int jumpCount = 0;
    bool dashSkill = false;
   // bool isGrounded = false;
    Rigidbody2D rb;

    public GameObject skill;
    public GameObject dashObstacle;
    public GameObject pHpScript; //player hp script
    public GameObject wMoveScript; //world move script
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void Jump()
    {
         //if (Input.GetKeyDown(KeyCode.Space))
         {
             if (jumpCount == 0)
             {
                 gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump1, 0);
                 jumpCount += 1;
             }
             else if (jumpCount == 1)
             {
                 gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
                 jumpCount += 2;
             }
         }
        
        /*if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;

        }
        if (inputJump && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jump2;
            extraJumps--;
            inputJump = false;

        }
        else if (inputJump && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jump1;
            inputJump = false;

        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            // extraJumps = extraJumpsValue;
            //isGrounded = true;
            jumpCount = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SurfingGate"))
        {
            skill.SetActive(true);
        }
        if (dashSkill == true)
        {
            
            if (collision.gameObject.CompareTag("dashObstacle"))
            {
                Destroy(dashObstacle);
                dashSkill = false;
                skill.SetActive(false);
                wMoveScript.GetComponent<WorldMove>().speed = 10.0f;
                
            }
        }
        else if (collision.gameObject.CompareTag("dashObstacle"))
        {
            pHpScript.GetComponent<Player_HP>().PlayerHP -= 1;
        }
    }
    public void DashSkill()
    {
        if (dashCount == 1)
        {
            dashSkill = true;
            wMoveScript.GetComponent<WorldMove>().speed = 20.0f;
            Invoke("dashAfter", 2f);
            dashCount = 0;
        }
    }
    void dashAfter()
    {
        wMoveScript.GetComponent<WorldMove>().speed = 10.0f;
        skill.SetActive(false);
        dashSkill = false;
    }
}
