using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width_obstacle : MonoBehaviour
{


    public bool width;
    public GameObject detect_obs;
    public float speed; // �ӵ��� ����


    void Start()
    {

    }


    void Update()
    {
        Speed();
        width = detect_obs.GetComponent<width_detect>().detect;

        if (transform.position.x < -13f) // ȭ�� ��(-9.2f)������ ���� ��� ���ư��� ���� ��ֹ� ����
        {
            Destroy(gameObject);
        }

    }

    public void Speed()
    {
        if (width == true)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }
    }

}