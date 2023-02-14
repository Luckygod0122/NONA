using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Point : MonoBehaviour
{

    public PointController PointControllerScript;
    public WorldMove WorldMoveScript;
    public GameObject Player;

    public float PlayerSpeed;

    void Start()
    {
        PlayerSpeed = 0;
    }


    void Update()
    {
        Player.transform.Translate(1 * PlayerSpeed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PointControllerScript.IfStageClear();
            WorldMoveScript.speed = 0;
            PlayerSpeed = 8;
        }
    }
}
