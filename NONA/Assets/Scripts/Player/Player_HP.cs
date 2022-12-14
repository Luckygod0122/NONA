using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public int PlayerHP = 1; // 플레이어 시작 체력 1
    public int part = 0; // 플레이어가 시작할 때 먹은 부품의 갯수 
    public int Score = 0; // 부품을 먹었을 때 얻는 점수

    void Update()
    {
        if (PlayerHP == 0) // 플레이어 체력이 0일 경우 사망
        {
            Dead();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle")) // 부딪힌 것의 태그가 obstacle일 경우
        {
            PlayerHP -= 1; // 플레이어 체력 -1
        }
        else if (collision.CompareTag("Part")) // 부딪힌 것의 태그가 Part일 경우
        {
            part += 1;   // part 1개씩 추가
            Score += 10;
            if (part == 5) // 만약 part가 5개라면 플레이어 체력 +1
            {
                part = 0;
                PlayerHP += 1;
            }
        }
    }

    private void Dead() // 플레이어 사망 시 부서짐
    {
        Destroy(this.gameObject);
    }
}
