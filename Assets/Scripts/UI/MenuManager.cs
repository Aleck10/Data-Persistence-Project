using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;


public class MenuManager : MonoBehaviour
{
    public string PlayerName;
    public int BestScore;

    public string BestPlayerEver;
    public int BestScoreEver;

    public static MenuManager Instance;



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    [System.Serializable]
    class SaveData
    {
        public string BestPlayerEver;
        public int BestScoreEver;
    }



    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.BestPlayerEver = BestPlayerEver;
        data.BestScoreEver = BestScoreEver;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);


    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestPlayerEver = data.BestPlayerEver;
            BestScoreEver = data.BestScoreEver;
        }
    }


}
