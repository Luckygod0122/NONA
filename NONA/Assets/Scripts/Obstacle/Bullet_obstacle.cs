using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_obstacle : MonoBehaviour
{
    
    public GameObject Bullet;
    public Transform Pos;
    public float cooltime;
    private float curtime;
    public int ball_cnt;

    void Start()
    {
           

    }

    
    void Update()
    {
        bullet_spawn();
        Delay();
    
    }

    private void bullet_spawn()
    {
        if (curtime <= 0)
        {
            Instantiate(Bullet, Pos.position, transform.rotation);
            curtime = cooltime;
            ball_cnt += 1;
            if(ball_cnt > 3)
            {
                ball_cnt = 0;
            }
        }
        curtime -= Time.deltaTime;
    }

    private void Delay()
    {
        if (ball_cnt == 3)
        {
            Invoke("bullet_spawn", 3);
        }
    }


}
