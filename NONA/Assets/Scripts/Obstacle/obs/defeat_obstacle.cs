using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat_obstacle : MonoBehaviour
{
    public GameObject detect_obj;
    public bool defeat;
    public float speed; // 속도값 조정



    void Start()
    {
        
    }
    

    void Update()
    {
        Speed();
        defeat = detect_obj.GetComponent<defeat_detect>().defeat_obs;

        if (transform.position.x < -13f) // 화면 밖(-9.2f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
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