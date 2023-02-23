using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]

public class Data
{
    public bool[] IfUnlock = new bool[6];
    public int[] StageScore = new int[6];

    public float BGMVolume;
    public float SEVolume;
}

public class SaveData : MonoBehaviour
{

}
