using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat_obstacle : MonoBehaviour
{
    public GameObject detect_obj;
    public bool defeat;
    public float speed; // �ӵ��� ����



    void Start()
    {
        
    }
    

    void Update()
    {
        Speed();
        defeat = detect_obj.GetComponent<defeat_detect>().defeat_obs;

        if (transform.position.x < -13f) // ȭ�� ��(-9.2f)������ ���� ��� ���ư��� ���� ��ֹ� ����
        {
            Destroy(gameObject);
        }
    }

    void Speed()
    {
        if (defeat == true)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }
    }




}