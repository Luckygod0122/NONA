using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_obstacle : MonoBehaviour
{
    //위산 생성
    public GameObject Bullet;
    public Transform Pos;
    public float cooltime;
    private float curtime;

    //위산 생성 개수
    public int ball_cnt;

    //위산이 중간에 멈추도록 bool함수 사용
    public bool ball_sp = true;

    //시간이 지나면 다시 위산을 생성하도록 하기위한 조건
    public float rTime;
  

    void Start()
    {
        

    }

    
    void Update()
    {
        rTime += Time.deltaTime;
       
        bullet_spawn();
           
    }

    private void bullet_spawn() // 위산 생성
    {
        if (ball_sp == true)
        {
            if (curtime <= 0)
            {
                Instantiate(Bullet, Pos.position, transform.rotation);
                curtime = cooltime;
                ball_cnt += 1;

                if (ball_cnt == 3)
                {
                    ball_cnt = 0;
                    ball_sp = false;



                }


            }
            curtime -= Time.deltaTime;
        }
       
        else if (rTime > 1.5) // 1.7 / 2 / 2.5 // 시간이 1.7초 이상일 떄
        {
            rTime = 0; // 시간을 다시 0으로 초기화 시키고
            ball_sp = true; // 다시 작동하도록 ball_sp을 true로 변환
            
        }




    }

 

    


}
