using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public string[] itemIsSelected = new string[2];
    //public bool menuAudioIsDisabled;
    //public bool gameAudioIsDisabled;

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

    private void Start()
    {
        
    }
    //[System.Serializable]
    //class SaveData
    //{
    //    public bool[] itemIsSelected;
    //    //public bool menuAudioIsDisabled;
    //    //public bool gameAudioIsDisabled;
    //}

    //public void SaveItemState()
    //{
    //    SaveData data = new SaveData();
    //    data.itemIsSelected = itemIsSelected;
    //    //data.menuAudioIsDisabled = menuAudioIsDisabled;
    //    //data.gameAudioIsDisabled = gameAudioIsDisabled;

    //    string json = JsonUtility.ToJson(data);

    //    File.WriteAllText(Application.persistentDataPath + "/itemstate.json", json);
    //}

    //public void LoadItemState()
    //{
    //    string path = Application.persistentDataPath + "/itemstate.json";
    //    if (File.Exists(path))
    //    {
    //        string json = File.ReadAllText(path);
    //        SaveData data = JsonUtility.FromJson<SaveData>(json);

    //        itemIsSelected = data.itemIsSelected;
    //        //menuAudioIsDisabled = data.menuAudioIsDisabled;
    //        //gameAudioIsDisabled = data.gameAudioIsDisabled;
    //    }
    //}
}
