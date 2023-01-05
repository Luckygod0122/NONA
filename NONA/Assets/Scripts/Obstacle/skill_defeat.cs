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




    //bool함수를 사용하여 박스콜라이더 안에 장애물이 들어왔을 때 버튼을 누를 시 범위 내 장애물 destroy하기

}
