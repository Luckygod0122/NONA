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
        }
    }

    public void SaveGameData()
    {
        DataManager.Instance.data.BGMVolume = PlayerPrefs.GetFloat("BGMVolume");
        DataManager.Instance.data.SEVolume = PlayerPrefs.GetFloat("SEVolume");

        Debug.Log(DataManager.Instance.data.BGMVolume);
        Debug.Log(DataManager.Instance.data.SEVolume);
        Debug.Log(PlayerPrefs.GetFloat("BGMVolume"));
        Debug.Log(PlayerPrefs.GetFloat("SEVolume"));


        string TojsonData = JsonUtility.ToJson(data, true);
        string FilePath = Application.persistentDataPath + "/" + GameDataFileName;

        File.WriteAllText(FilePath, TojsonData);
    }
}
