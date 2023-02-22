using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadGameData();
    }

    public void StageUnlock(int StageNumber)
    {
        DataManager.Instance.data.IfUnlock[StageNumber] = true;
        DataManager.Instance.SaveGameData();
    }
}