using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_Detected : MonoBehaviour
{
    public GameObject B_obs;  // 튀어오를 장애물
    public bool deTect = false; // 접촉하였을 때 작동하도록 처음을 false로 설정
    
    void Start()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 만약 태그가 Player라면
        {
            deTect = true; // deTect를 True로 반환하여 Bounce_obstacle을 실행하도록 하기
            
        }
    }
    void Update()
    {
        if (B_obs.transform.position.y > -1.17)  // 만약 튀어오를 장애물이 일정 높이를 튀어올랐을 경우
        {
            deTect = false; // deTect를 false로 반환
        }
    }
}
