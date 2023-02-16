using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSettings : MonoBehaviour
{
    public SoundManager soundManager;
    public GameObject TouchArea;

    public AudioClip TitleBGM;

    void Start()
    {
        soundManager.BGMPlayer("TitleBGM", TitleBGM, 0.1f);
    }

}
