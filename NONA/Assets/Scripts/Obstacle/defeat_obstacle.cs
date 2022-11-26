using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat_obstacle : MonoBehaviour
{

    

    
   
    public float distance; // 감지 범위
    public LayerMask isLayer; // 감지할 레이어
    public float speed; // 속도값 조정
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


        if (transform.position.x < -13f) // 화면 밖(-9.2f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
        {
            Destroy(this.gameObject);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))   // 만약 플레이어와 닿았을 경우 날아가는 가로 장애물 삭제
        {
            Destroy(this.gameObject);
        }
    }
}