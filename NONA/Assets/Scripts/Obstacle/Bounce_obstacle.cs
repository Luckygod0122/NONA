using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_obstacle : MonoBehaviour
{
    public GameObject detect_obs; // ������ ��ġ

    Rigidbody2D myrig;

    public bool bounce; // ������ �������� �Ǻ�
    public float power; // ���� ���ư� ��


    void Start()
    {
        myrig = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
        Bounce_Speed();
        bounce = detect_obs.GetComponent<Bounce_Detected>().deTect; // ������ ��ġ�� player�� ����� ��� Bounce_Detected�� ����ǵ��� �ϱ�
    }

    public void Bounce_Speed()
    {
        if (bounce == true) // ������ �Ǿ�����
        {
            myrig.velocity = Vector2.up * power; // ���� Ƣ��������� �ϱ�
            GetComponent<Rigidbody2D>().gravityScale = 1; // ���� ���� �ö��� �� �����������ϱ����� �߷��� 1�� �������

        }
        
    }
}
