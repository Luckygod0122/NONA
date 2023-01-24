using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Vertical_obs : MonoBehaviour
{
    public GameObject obstacle;
    public float speed; // 속도값 조정
    public bool up_obs;

    void Start()
    {

    }


    void Update()
    {
        Up_Speed();
        up_obs = obstacle.GetComponent<Top_detect>().Detect;

    }

    public void Up_Speed()
    {
        if (up_obs == true)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); // 날아가는 속도

            if (transform.position.y > -2.28f) // 화면 밖(-2.49f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
            {
                speed = 0;
            } //-1.955379 // -2.946831
        }


    }
}
