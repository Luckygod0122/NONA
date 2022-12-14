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
    public bool ball_sp = true;
    public GameObject player;
    public int a = 0;

    void Start()
    {
        

    }

    
    void Update()
    {
        a = player.GetComponent<Player_HP>().part;
        bullet_spawn();
           
    }

    private void bullet_spawn()
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
        else if (a == 4)
        {
            
            ball_sp = true;
            
        }




    }

 

    


}
