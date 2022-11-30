using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_target : MonoBehaviour
{
    public GameObject  obstacle;
    public float speed;
    bool obs;

    void Start()
    {
       obs = obstacle.GetComponent<top_smoke_obstacle>().k;


    }

    
    void Update()
    {
        Speed();
    }
    public void Speed()
    {
        if (obs == true)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); // 날아가는 속도
        }


        else if (transform.position.y < 2.7f) // 화면 밖(-2.49f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
        {
            speed = 0;
        }
    }
}
