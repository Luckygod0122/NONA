using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Vertical_obs : MonoBehaviour
{
    public GameObject obstacle;
    public float speed; // �ӵ��� ����
    public bool up_obs;

    void Start()
    {

    }


    void Update()
    {
        Up_Speed();
        up_obs = obstacle.GetComponent<Top_detect>().Detect;

    }

    public void Up_Speed()
    {
        if (up_obs == true)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); // ���ư��� �ӵ�

            if (transform.position.y > -2.28f) // ȭ�� ��(-2.49f)������ ���� ��� ���ư��� ���� ��ֹ� ����
            {
                speed = 0;
            } //-1.955379 // -2.946831
        }


    }
}
