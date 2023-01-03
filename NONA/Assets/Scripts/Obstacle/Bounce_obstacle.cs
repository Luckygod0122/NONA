using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_obstacle : MonoBehaviour
{
    public GameObject detect_obs; // 감지할 장치

    Rigidbody2D myrig;

    public bool bounce; // 참인지 거짓인지 판별
    public float power; // 위로 날아갈 힘


    void Start()
    {
        myrig = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
        Bounce_Speed();
        bounce = detect_obs.GetComponent<Bounce_Detected>().deTect; // 감지할 장치가 player와 닿았을 경우 Bounce_Detected가 실행되도록 하기
    }

    public void Bounce_Speed()
    {
        if (bounce == true) // 실행이 되었을떄
        {
            myrig.velocity = Vector2.up * power; // 위로 튀어오르도록 하기
            GetComponent<Rigidbody2D>().gravityScale = 1; // 일정 높이 올라갔을 때 떨어지도록하기위해 중력을 1로 만들어줌

        }
        
    }
}
