using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class skill_defeat : MonoBehaviour, IPointerDownHandler
{
    public GameObject obs;
    public GameObject button;
    public int attack = 5;
    public bool attack_stop = false;
   
    void Start()
    {
       
    }


    void Update()
    {
        obs = GameObject.Find("defeat_obstacle");

        if (attack == 0)
        {
            attack_stop = true;
            if (attack_stop == true)
            {
                button.SetActive(false);
            }
        }

    }

  
    public void OnPointerDown(PointerEventData eventData)
    {
        attack -= 1;
        if (scope.inside == true && attack >= 0)
        {
            Destroy(obs);
        }
        


    }


}

