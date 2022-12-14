using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerUIManager : MonoBehaviour
{
    public GameObject PlayerScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void JumpClick()
    {
        PlayerScript.GetComponent<PlayerController>().Jump();
    }
    public void SkillClick()
    {
        PlayerScript.GetComponent<PlayerController>().DashSkill();
    }
}
