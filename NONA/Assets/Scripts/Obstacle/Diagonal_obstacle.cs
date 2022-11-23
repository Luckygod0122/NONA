using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diagonal_obstacle : MonoBehaviour
{
    public float distance; // 감지 범위
    public LayerMask isLayer; // 감지할 레이어
    public float speed2 = 0.0025f;
   // Vector3 target;
   // Vector3 os; // 장애물
   // Vector3 newos; 


    

    void Start()
    {
        
        //target = GameObject.Find("Player_target_Diagonal").transform.position;
       // os = transform.position;

       // newos = (target - os) * speed2;
    }

    void Update()
    {
        //transform.position = transform.position + newos;
        if (transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
       
        
    }
    void FixedUpdate()
    {
        RaycastHit2D raycast = Physics2D.Raycast(transform.position, transform.right * -1, distance, isLayer);
        if (raycast.collider != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, raycast.collider.transform.position, Time.deltaTime * speed2);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

   



}
