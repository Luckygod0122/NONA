using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectController : MonoBehaviour
{
    public GameObject LeftStageButton;
    public GameObject RightStageButton;

    public GameObject EmptyChart;

    public GameObject W1S1;
    public GameObject W1S2;
    public GameObject W2S1;
    public GameObject W2S2;
    public GameObject W3S1;
    public GameObject W3S2;

    public GameObject CurrentStage;
    public GameObject SameWorldStage;

    public SoundManager soundManager;
    public AudioClip StageSelectBGM;

    public GameObject StageMoveScript;

    public GameObject World1Image;
    public GameObject World2Image;
    public GameObject World3Image;


    void Start()
    {
        CurrentStage = W1S1;
        SameWorldStage = W1S2;

        soundManager.BGMPlayer("StageSelectBGM", StageSelectBGM);
    }

    public void World1Button()
    {
        SetOffAll();
        StageMoveScript.GetComponent<StageSelectMove>().MoveWorld(CurrentStage, W1S1, RightStageButton);
        
        CurrentStage = W1S1;
        SameWorldStage = W1S2;

        World1Image.SetActive(true);
        World2Image.SetActive(false);
        World3Image.SetActive(false);

        LeftStageButton.SetActive(false);

    }

    public void World2Button()
    {
        SetOffAll();
        StageMoveScript.GetComponent<StageSelectMove>().MoveWorld(CurrentStage, W2S1, RightStageButton);

        CurrentStage = W2S1;
        SameWorldStage = W2S2;

        World1Image.SetActive(false);
        World2Image.SetActive(true);
        World3Image.SetActive(false);

        LeftStageButton.SetActive(false);
    }

    public void World3Button()
    {
        SetOffAll();
        StageMoveScript.GetComponent<StageSelectMove>().MoveWorld(CurrentStage, W3S1, RightStageButton);

        CurrentStage = W3S1;
        SameWorldStage = W3S2;

        World1Image.SetActive(false);
        World2Image.SetActive(false);
        World3Image.SetActive(true);

        LeftStageButton.SetActive(false);
    }

    public void LeftButton()
    {
        LeftStageButton.SetActive(false);

        StageMoveScript.GetComponent<StageSelectMove>().MoveStage1(CurrentStage, SameWorldStage, RightStageButton);

        GameObject temp = SameWorldStage;
        SameWorldStage = CurrentStage;
        CurrentStage = temp;
    }

    public void RightButton()
    {
        RightStageButton.SetActive(false);

        StageMoveScript.GetComponent<StageSelectMove>().MoveStage2(CurrentStage, SameWorldStage, LeftStageButton);

        GameObject temp = SameWorldStage;
        SameWorldStage = CurrentStage;
        CurrentStage = temp;
    }

    public void SetOffAll()
    {
        W1S1.SetActive(false);
        W1S2.SetActive(false);

        W2S1.SetActive(false);
        W2S2.SetActive(false);

        W3S1.SetActive(false);
        W3S2.SetActive(false);
    }

}
