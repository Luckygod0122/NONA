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


// 장애물이 범위 안에 들어왔을 떄 버튼이 활성화 -> 활성화 되었을 때 클릭 시 범위 안에 있는 장애물 제거