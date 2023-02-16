using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public GameObject worldmove;
    public Animator anim;

    public int PlayerHP = 1; // 플레이어 시작 체력 1
    public int part = 0; // 플레이어가 시작할 때 먹은 부품의 갯수 
    public int count = 0;

    public AudioSource mysfx;
    public AudioClip ReviveSound;
    public AudioClip GetLife;
    public AudioClip DieSound;
    public AudioClip HitSound;

    public StageEnd EndScript;

    private void Start()
    {

    }
    void Update()
    {
        if (PlayerHP == 0) // 플레이어 체력이 0일 경우 사망
        {
            Dead();
            EndScript.ShowResult(4);
        }
        if (PlayerHP > 5)
        {
            PlayerHP = 5;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle")) // 부딪힌 것의 태그가 obstacle일 경우
        {
            if (count == 0)
            {
                PlayerHP -= 1; // 플레이어 체력 -1
                count = 1;
                mysfx.PlayOneShot(HitSound);

            }
            
            else if (count == 1)
            {
                PlayerHP -= 0; // 무적 판정
                Invoke("inv", 3);
                
            }
            
        }
        else if (collision.CompareTag("Part")) // 부딪힌 것의 태그가 Part일 경우
        {
            part += 1;   // part 1개씩 추가
            if (part % 100 == 0) // 만약 part가 5개라면 플레이어 체력 +1
            {
                PlayerHP += 1;
                mysfx.PlayOneShot(GetLife);
            }
        }
    }

    private void Dead() // 플레이어 사망 시 부서짐
    {
//        Destroy(this.gameObject, 1f);
        worldmove.gameObject.GetComponent<WorldMove>().speed = 0;
        anim.SetBool("Die",true);
       mysfx.PlayOneShot(DieSound);
    }

    private void inv() //무적 판정 함수
    {
        count = 0;
    }

}
