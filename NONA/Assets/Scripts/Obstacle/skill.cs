using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    public GameObject scope;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void Attack_skill()
    {
        scope.GetComponent<skill_defeat>().Attack();
    }
}
