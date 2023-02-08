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
                SceneManager.LoadScene("World1-1");
                break;
            case "1-2":
                SceneManager.LoadScene("World1-2");
                break;
            case "2-1":
                SceneManager.LoadScene("World2-1");
                break;
            case "2-2":
                SceneManager.LoadScene("World2-2");
                break;
/*            case "3-1":
                SceneManager.LoadScene("StageUITest");
                break;
            case "3-2":
                SceneManager.LoadScene("StageUITest");
                break;*/
        }
    }

}
