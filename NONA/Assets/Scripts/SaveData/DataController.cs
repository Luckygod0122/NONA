using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadGameData();
        PlayerPrefs.SetFloat("BGMVolume", DataManager.Instance.data.BGMVolume);
        PlayerPrefs.SetFloat("SEVolume", DataManager.Instance.data.SEVolume);
    }

    public void StageUnlock(int StageNumber)
    {
        DataManager.Instance.data.IfUnlock[StageNumber] = true;
        DataManager.Instance.SaveGameData();
    }

    private void OnApplicationQuit()
    {
        //DataManager.Instance.data.BGMVolume = PlayerPrefs.GetFloat("BGMVolume");
        //DataManager.Instance.data.SEVolume = PlayerPrefs.GetFloat("SEVolume");

        //Debug.Log(DataManager.Instance.data.BGMVolume);
        //Debug.Log(DataManager.Instance.data.SEVolume);
        //Debug.Log(PlayerPrefs.GetFloat("BGMVolume"));
        //Debug.Log(PlayerPrefs.GetFloat("SEVolume"));


        DataManager.Instance.SaveGameData();

        Debug.Log(DataManager.Instance.data.BGMVolume);
        Debug.Log(DataManager.Instance.data.SEVolume);
        Debug.Log(PlayerPrefs.GetFloat("BGMVolume"));
        Debug.Log(PlayerPrefs.GetFloat("SEVolume"));

    }
}
