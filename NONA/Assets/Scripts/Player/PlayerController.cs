using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Animator anim;

    public float jump1 = 10.0f;
    public float jump2 = 12.0f;

    static public int surfingJumpCount = 0;
    int jumpCount = 0;
    public bool dashSkill = false;

    public GameObject surfingSkill;
    public GameObject skillFalse;
    public GameObject Surfing_Skill_False;
    public GameObject Flying_Skill;
    public GameObject Flying_Skill_False;
    public GameObject SurfingJump_Button;
    public GameObject Jump_Button;
    public GameObject Surfing_Jump_Down;
    public GameObject FlyingJump_Button;
    public GameObject Flying_Jump_Down;
    public GameObject dashObstacle;
    public GameObject pHpScript; //player hp script
    public GameObject wMoveScript; //world move script
    public AudioSource mysfx;
    public AudioClip jumpsfx;
   
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void Jump()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount == 0 && !anim.GetBool("IsJumping"))
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump1, 0);
                jumpCount += 1;
                anim.SetBool("IsJumping", true);
                JumpSound();
            }
            else if (jumpCount == 1)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
                jumpCount += 1;
                JumpSound();
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            surfingJumpCount = 1;
            anim.SetBool("IsJumping", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SurfingGate"))
        {
            skillFalse.SetActive(false);
            surfingSkill.SetActive(true);
            SurfingJump_Button.SetActive(true);
            Jump_Button.SetActive(false);
            anim.SetBool("Surfing", true);
        }
        if (collision.gameObject.CompareTag("SurfingGateEnd"))
        {
            surfingSkill.SetActive(false);
            skillFalse.SetActive(true);
            Surfing_Jump_Down.SetActive(false);
            Surfing_Skill_False.gameObject.SetActive(false);
            SurfingJump_Button.SetActive(false);
            Jump_Button.SetActive(true);
            anim.SetBool("Surfing", false);
        }
        if (collision.gameObject.CompareTag("FlyingGate"))
        {
            skillFalse.SetActive(false);
            Flying_Skill.SetActive(true);
            FlyingJump_Button.SetActive(true);
            Jump_Button.SetActive(false);
        }
        if (collision.gameObject.CompareTag("FlyingGateEnd"))
        {
            Flying_Skill.SetActive(false);
            Flying_Skill_False.SetActive(false);
            skillFalse.SetActive(true);
            FlyingJump_Button.SetActive(false);
            Jump_Button.SetActive(true);
            Flying_Jump_Down.SetActive(false);
        }
        if (dashSkill == true)
        {

            if (collision.gameObject.CompareTag("dashObstacle"))
            {
                // Destroy(dashObstacle);
                dashSkill = false;
                surfingSkill.SetActive(false);
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

        dashSkill = true;
        wMoveScript.GetComponent<WorldMove>().speed = 20.0f;
        Invoke("dashAfter", 2f);
    }
    void dashAfter()
    {
        wMoveScript.GetComponent<WorldMove>().speed = 8.0f;
        surfingSkill.SetActive(false);
        dashSkill = false;
    }

    public void JumpSound()
    {
        mysfx.PlayOneShot(jumpsfx);
    }
}
