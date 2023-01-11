using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Up : MonoBehaviour, IPointerDownHandler , IPointerUpHandler
{
    public bool up = false;
    public int speed;
    public GameObject Up_button;
    public GameObject Down_button;
    public GameObject Player;

    void Start()
    {

    }


    void Update()
    {
        if (up == true)
        {
            Player.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        up = true;
        if (up == true)
        {
            speed = 5;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        up = false;
        if (up == false)
        {
            speed = 0;
        }
    }

}
