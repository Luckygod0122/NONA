using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_defeat : MonoBehaviour
{
    public GameObject Scope;
    public GameObject obs;
    public bool inside = false;
    public int attack = 5;


    void Start()
    {

    }


    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && inside == true)
        {
            Destroy(obs);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("defeat"))
        {
            inside = true;
        }
    }




    //bool�Լ��� ����Ͽ� �ڽ��ݶ��̴� �ȿ� ��ֹ��� ������ �� ��ư�� ���� �� ���� �� ��ֹ� destroy�ϱ�

}
