using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    static GameObject container;

    static DataManager instance;
    public static DataManager Instance
    {
        get
        {
            if (!instance)
            {
                container = new GameObject();
                container.name = "DataManager";
                instance = container.AddComponent(typeof(DataManager)) as DataManager;
                DontDestroyOnLoad(container);
            }
            return instance;
        }
    }

    string GameDataFileName = "GameData.json";

    public Data data = new Data();

    public void LoadGameData()
    {
        string FilePath = Application.persistentDataPath + "/" + GameDataFileName;

        if (File.Exists(FilePath))
        {
            string FromjsonData = File.ReadAllText(FilePath);
            data = JsonUtility.FromJson<Data>(FromjsonData);

            PlayerPrefs.SetFloat("BGMVolume", data.BGMVolume);
            PlayerPrefs.SetFloat("SEVolume", data.SEVolume);
        }
        else
        {
            PlayerPrefs.SetFloat("BGMVolume", 1.0f);
            PlayerPrefs.SetFloat("SEVolume", 1.0f);
        }
    }

    public void SaveGameData()
    {
        data.BGMVolume = PlayerPrefs.GetFloat("BGMVolume");
        data.SEVolume = PlayerPrefs.GetFloat("SEVolume");

        string TojsonData = JsonUtility.ToJson(data, true);
        string FilePath = Application.persistentDataPath + "/" + GameDataFileName;

        File.WriteAllText(FilePath, TojsonData);
    }

    private void OnApplicationQuit()
    {
        SaveGameData();
    }

}
