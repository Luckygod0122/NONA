using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class StageStart : MonoBehaviour
{
    public GameObject Current;
    public GameObject StageSelectControllerScript;

    void Update()
    {
        Current = StageSelectControllerScript.GetComponent<StageSelectController>().CurrentStage;
    }

    public void StageStartButton()
    {
        switch(Current.name)
        {
            case "1-1":
                StartW1S1();
                break;
        }
    }

    public void StartW1S1()
    {
        SceneManager.LoadScene("StageUITest");
    }    
}
