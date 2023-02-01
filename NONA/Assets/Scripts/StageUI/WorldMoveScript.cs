using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class WorldMoveScript : MonoBehaviour
{
    public float speed;

    public float TimeCount = 0f;

    public Animation StartAnimation;

    void Update()
    {
        TimeCount += Time.deltaTime;
        if(TimeCount <= 0.8f)
        {
            return;
        }
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

    }
}
