using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerUIManager : MonoBehaviour
{
    PlayerController PlayerScript;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JumpClick()
    {
        Debug.Log("jump");

    }
    public void SkillClick()
    {
        
    }
}
