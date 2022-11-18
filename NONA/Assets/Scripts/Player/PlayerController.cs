using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jump1 = 10.0f;
    public float jump2 = 12.0f;
    public int jumpCount = 0;
    public bool inputJump = false;
    public GameObject skill;
    public float speed = 2.0f;
    public GameObject WorldMoveScript;
    public int skillCount = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DashGate"))
        {
            skill.SetActive(true);
        }
    }
    public void DashSkill()
    {
        WorldMoveScript.GetComponent<WorldMove>().speed = 20.0f;
        skillCount--;
    }
}
