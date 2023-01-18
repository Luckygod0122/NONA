using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_obstacle : MonoBehaviour
{
    //���� ����
    public GameObject Bullet;
    public Transform Pos;
    public float cooltime;
    private float curtime;

    //���� ���� ����
    public int ball_cnt;

    //������ �߰��� ���ߵ��� bool�Լ� ���
    public bool ball_sp = true;

    //�ð��� ������ �ٽ� ������ �����ϵ��� �ϱ����� ����
    public float rTime;
  

    void Start()
    {
        

    }

    
    void Update()
    {
        rTime += Time.deltaTime;
       
        bullet_spawn();
           
    }

    private void bullet_spawn() // ���� ����
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
       
        else if (rTime > 1.5) // 1.7 / 2 / 2.5 // �ð��� 1.7�� �̻��� ��
        {
            rTime = 0; // �ð��� �ٽ� 0���� �ʱ�ȭ ��Ű��
            ball_sp = true; // �ٽ� �۵��ϵ��� ball_sp�� true�� ��ȯ
            
        }




    }

 

    


}
