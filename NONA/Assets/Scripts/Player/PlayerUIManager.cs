using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerUIManager : MonoBehaviour
{
    public GameObject PlayerScript;
    public GameObject Jump_Down;
    public GameObject Skill_Button;
    public GameObject Skill_Down;
    public GameObject Skill_False;
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
        Jump_Down.gameObject.SetActive(true);
        Invoke("Jump_Down_False", 0.1f);

    }
    public void SkillClick()
    {
        PlayerScript.GetComponent<PlayerController>().DashSkill();
        Skill_Down.gameObject.SetActive(true);
        Invoke("Skill_END", 2f);
    }   

    public void Jump_Down_False()
    {
        Jump_Down.gameObject.SetActive(false);
    }

    public void Skill_END()
    {
        Skill_Button.gameObject.SetActive(false);
        Skill_Down.gameObject.SetActive(false);
        Skill_False.gameObject.SetActive(true);
    }
}
