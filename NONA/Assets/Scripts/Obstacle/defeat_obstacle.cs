using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat_obstacle : MonoBehaviour
{

    

    
   
    public float distance; // ���� ����
    public LayerMask isLayer; // ������ ���̾�
    public float speed; // �ӵ��� ����
    void Start()
    {
        
    }
    

    void FixedUpdate()
    {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, transform.right * -1, distance, isLayer);
        if (raycast.collider != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, raycast.collider.transform.position, Time.deltaTime * speed);
        }

    }

    void Update()
    {


        if (transform.position.x < -13f) // ȭ�� ��(-9.2f)������ ���� ��� ���ư��� ���� ��ֹ� ����
        {
            Destroy(this.gameObject);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))   // ���� �÷��̾�� ����� ��� ���ư��� ���� ��ֹ� ����
        {
            Destroy(this.gameObject);
        }
    }
}