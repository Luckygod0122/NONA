using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Down : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool down = false;
    public int speed;
    public GameObject Up_button;
    public GameObject Down_button;
    public GameObject Player;

    void Start()
    {
        Player.GetComponent<Rigidbody2D>().gravityScale = 0;
    }


    void Update()
    {
        if (down == true)
        {
            Player.transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        down = true;
        if (down == true)
        {
            speed = 5;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        down = false;
        if (down == false)
        {
            speed = 0;
        }
    }
}
