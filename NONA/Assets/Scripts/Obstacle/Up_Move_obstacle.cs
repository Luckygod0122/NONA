using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Move_obstacle : MonoBehaviour
{
    public float speed3; // 속도값 조정
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.up * speed3 * Time.deltaTime); // 날아가는 속도

        if (transform.position.y > 4.71f) // 올라갈 때 최대치 4.71f까지 올라갔을 경우
        {
            speed3 = speed3 * -1; // speed3값에 음수를 곱하여 내려가도록 설정
        }
        if (transform.position.y < 2.56f) // 내려갈 때 최대치 2.56f까지 내려갔을 경우
        {
            speed3 = speed3 * -1; // speed3값에 다시 음수를 곱하여 올라가도록 설정
        }

    }
}
