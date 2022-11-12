using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMTest : MonoBehaviour
{
    public SoundManager SoundManager;

    // Start is called before the first frame update
    public void button1()
    {
        SoundManager.BGMPlayer("Test");
    }

    public void button2()
    {
        SoundManager.BGMPlayer("Test_Title");
    }
}
