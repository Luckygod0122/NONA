using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSettings : MonoBehaviour
{
    public SoundManager soundManager;
    public GameObject OptionSet;
    public GameObject TouchArea;

    void Start()
    {
        soundManager.BGMPlayer(0);
    }

}
