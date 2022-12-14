using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectController : MonoBehaviour
{
    public GameObject LeftStageButton;
    public GameObject RightStageButton;

    public GameObject W1S1;
    public GameObject W1S2;

    public GameObject W2S1;
    public GameObject W2S2;
    
    public GameObject W3S1;
    public GameObject W3S2;

    public SoundManager soundManager;
    public AudioClip StageSelectBGM;

    private void Start()
    {
        soundManager.BGMPlayer("StageSelectBGM", StageSelectBGM);
    }

    public void World1Button()
    {
        W1S1.SetActive(true);
        W1S2.SetActive(false);

        W2S1.SetActive(false);
        W2S2.SetActive(false);

        W3S1.SetActive(false);
        W3S2.SetActive(false);

        RightStageButton.SetActive(true);
        LeftStageButton.SetActive(false);
    }

    public void World2Button()
    {
        W1S1.SetActive(false);
        W1S2.SetActive(false);

        W2S1.SetActive(true);
        W2S2.SetActive(false);

        W3S1.SetActive(false);
        W3S2.SetActive(false);

        RightStageButton.SetActive(true);
        LeftStageButton.SetActive(false);
    }

    public void World3Button()
    {
        W1S1.SetActive(false);
        W1S2.SetActive(false);

        W2S1.SetActive(false);
        W2S2.SetActive(false);

        W3S1.SetActive(true);
        W3S2.SetActive(false);

        RightStageButton.SetActive(true);
        LeftStageButton.SetActive(false);
    }

    public void LeftButton()
    {
        if(W1S2.activeSelf == true)
        {
            W1S1.SetActive(true);
            W1S2.SetActive(false);
        }

        if (W2S2.activeSelf == true)
        {
            W2S1.SetActive(true);
            W2S2.SetActive(false);
        }

        if (W3S2.activeSelf == true)
        {
            W3S1.SetActive(true);
            W3S2.SetActive(false);
        }

        LeftStageButton.SetActive(false);
        RightStageButton.SetActive(true);
    }

    public void RightButton()
    {
        if (W1S1.activeSelf == true)
        {
            W1S1.SetActive(false);
            W1S2.SetActive(true);
        }

        if (W2S1.activeSelf == true)
        {
            W2S1.SetActive(false);
            W2S2.SetActive(true);
        }

        if (W3S1.activeSelf == true)
        {
            W3S1.SetActive(false);
            W3S2.SetActive(true);
        }

        RightStageButton.SetActive(false);
        LeftStageButton.SetActive(true);
    }

}
