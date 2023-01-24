using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_smoke_obstacle : MonoBehaviour
{
    public GameObject  obstacle;
    public float speed;
    public bool down_obs;

    void Start()
    {
       


    }

    
    void Update()
    {
        Speed();
        down_obs = obstacle.GetComponent<Top_detect>().Detect;
    }

    public void Speed()
    {
        if (down_obs == true)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); // 날아가는 속도
            if (transform.position.y < 2.24222f) // 화면 밖(-2.49f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
            {
                speed = 0;
            }
        }


        
    }
}
