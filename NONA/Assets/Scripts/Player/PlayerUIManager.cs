using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerUIManager : MonoBehaviour
{
    public GameObject PlayerScript;
    public GameObject Jump_Down;
    public GameObject Surfing_Skill_Button;
    public GameObject Surfing_Skill_Down;
    public GameObject Surfing_Skill_False;
    public GameObject Surfing_Jump_Down;
    public GameObject Flying_Jump_Down;
    public GameObject Flying_Skill_Button;
    public GameObject Flying_Skill_Down;
    public GameObject Flying_Skill_False;
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
        Surfing_Skill_Down.gameObject.SetActive(true);
        Invoke("Surfing_Skill_END", 2f);
    }
    public void FlyingSkillClick()
    {
        PlayerScript.GetComponent<PlayerController>().DashSkill();
        Flying_Skill_Down.gameObject.SetActive(true);
        Invoke("Flying_Skill_END", 2f);
    }
    public void Flying_Skill_END()
    {
        Flying_Skill_Button.gameObject.SetActive(false);
        Flying_Skill_Down.gameObject.SetActive(false);
        Flying_Skill_False.gameObject.SetActive(true);
    }

    public void Jump_Down_False()
    {
        Jump_Down.gameObject.SetActive(false);
    }

    public void Surfing_Skill_END()
    {
        Surfing_Skill_Button.gameObject.SetActive(false);
        Surfing_Skill_Down.gameObject.SetActive(false);
        Surfing_Skill_False.gameObject.SetActive(true);
    }
    public void Surfing_Click_Down()
    {
        
        Surfing_Jump_Down.SetActive(true);
    }
    public void Surfing_Click_Up()
    {
        
        Surfing_Jump_Down.SetActive(false);
    }
    public void Flying_Click_Down()
    {

        Flying_Jump_Down.SetActive(true);
    }
    public void Flying_Click_Up()
    {

        Flying_Jump_Down.SetActive(false);
    }
}
