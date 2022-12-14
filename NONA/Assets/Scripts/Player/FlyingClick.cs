using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlyingClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isBtnDown;
    public float power = 9f;
    public GameObject Player;
    public GameObject UiScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isBtnDown == true)
        {
            Player.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * power;
        }
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;
        UiScript.GetComponent<PlayerUIManager>().Flying_Click_Down();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
        UiScript.GetComponent<PlayerUIManager>().Flying_Click_Up();
    }
    
}
