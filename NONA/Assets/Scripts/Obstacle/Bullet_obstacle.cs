using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_obstacle : MonoBehaviour
{
    
    public GameObject Bullet;
    public Transform Pos;
    public float cooltime;
    private float curtime;
    public float bull_cnt;

    void Start()
    {
        Invoke("cool", 3);
    }

    
    void Update()
    {
        if (curtime <= 0)
        {
            Instantiate(Bullet, Pos.position, transform.rotation);
            curtime = cooltime;
            bull_cnt += 1;
          

        }
        curtime -= Time.deltaTime;
    
    }
    void cool()
    {
        if (bull_cnt > 3)
        {
            // 3�� ��� ���߰� �ϱ�
            // bullet�� �����ϴ� �Ϳ� ������ �־��ֱ�
            bull_cnt *= 0;
        }
    }




}
