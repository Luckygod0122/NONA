using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_smoke_obstacle : MonoBehaviour
{

    public float speed; // 속도값 조정

    void Start()
    {

    }

  

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime); // 날아가는 속도

        if (transform.position.y < 2.7f) // 화면 밖(-2.49f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
        {
            speed = 0;
        }
    }
}
