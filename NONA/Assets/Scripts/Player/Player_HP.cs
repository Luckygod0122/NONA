using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public GameObject worldmove;
    public Animator anim;

    public int PlayerHP = 3; // 플레이어 시작 체력 1
    public int part = 0; // 플레이어가 시작할 때 먹은 부품의 갯수 
    public int count = 0;

    public AudioSource mysfx;
    public AudioClip ReviveSound;
    public AudioClip GetLife;
    public AudioClip DieSound;
    public AudioClip HitSound;

    public StageEnd EndScript;

    private SpriteRenderer Sprite; // 플레이어 체력 감소할 때 빨간색으로 색 변경 위해서 작성
    private Color originColor; // 원래 색깔

    private void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        originColor = Sprite.material.color;
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
                StartCoroutine(OnHitColor());
            }

            else if (count == 1)
            {
                StartCoroutine(unbeatable());
                // count = 0;
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

    // 플레이어 장애물 접촉 시, 무적 상태를 색으로 표시
    private IEnumerator OnHitColor()
    {
        Sprite.material.color = Color.red; // 빨간색으로 변경
        yield return new WaitForSeconds(0.1f); // 바로 윗줄 0.1초 대기
        Sprite.material.color = originColor;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = originColor;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = originColor;
        yield return new WaitForSeconds(0.1f);
    }

    private IEnumerator unbeatable() // 0.6초 무적
    {
        PlayerHP -= 0;
        yield return new WaitForSeconds(0.6f);
        count = 0;
    }

    private void Dead() // 플레이어 사망 시 부서짐
    {
//        Destroy(this.gameObject, 1f);
        worldmove.gameObject.GetComponent<WorldMove>().speed = 0;
        anim.SetBool("Die",true);
       mysfx.PlayOneShot(DieSound);
    }
}
