using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width_obstacle : MonoBehaviour
{
    public float speed; // �ӵ��� ����
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // ���ư��� �ӵ�

        if (transform.position.x < -9.2f) // ȭ�� ��(-9.2f)������ ���� ��� ���ư��� ���� ��ֹ� ����
        {
            Destroy(this.gameObject);
        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if(collision.gameObject.CompareTag("Player"))   // ���� �÷��̾�� ����� ��� ���ư��� ���� ��ֹ� ����
        {
            Destroy(this.gameObject);
        }
    }
}


// ������ �ϰ��ϴ� ��ֹ� --> �÷��̾�� ����� ��� ������ ���� �����Ͽ� �ϰ��ϵ��� �ϱ�   * �����Ÿ��� ������ ���� �ϰ��ϸ� �����ǵ��� �ϱ�
// ��ٰ� �߰��� �������� ��� --> ������ ���� �����·� �������� ��ũ��Ʈ