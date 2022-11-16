using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width_obstacle : MonoBehaviour
{
    public float speed; // 속도값 조정
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // 날아가는 속도

        if (transform.position.x < -9.2f) // 화면 밖(-9.2f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
        {
            Destroy(this.gameObject);
        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if(collision.gameObject.CompareTag("Player"))   // 만약 플레이어와 닿았을 경우 날아가는 가로 장애물 삭제
        {
            Destroy(this.gameObject);
        }
    }
}


// 밟으면 하강하는 장애물 --> 플레이어와 닿았을 경우 포지션 값을 변경하여 하강하도록 하기   * 일정거리로 포지션 값이 하강하면 삭제되도록 하기
// 밟다가 중간에 밟지않을 경우 --> 포지션 값을 원상태로 돌려놓는 스크립트