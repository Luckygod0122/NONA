using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_defeat : MonoBehaviour
{
    public GameObject Scope;
    public GameObject obs;
    public GameObject button;
    public bool inside = false;
    public int attack = 5;
   
    void Start()
    {
       
    }


    void Update()
    {
        obs = GameObject.Find("defeat_obstacle");
        Attack();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("defeat"))
        {
            inside = true;
        }
    }


    public void Attack()
    {
        if (inside == true && Input.GetMouseButtonDown(0))
        {
            Destroy(obs);
            attack -= 1;
            if (attack <= 0)
            {
                inside = false;
            }
        }
        
    }


}


// ��ֹ��� ���� �ȿ� ������ �� ��ư�� Ȱ��ȭ -> Ȱ��ȭ �Ǿ��� �� Ŭ�� �� ���� �ȿ� �ִ� ��ֹ� ����