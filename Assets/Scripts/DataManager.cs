using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public int selectedCategoryForGacha = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    //データの初期化。基本的には使わないが、初期状態に戻してテストプレイしたいときとか有効
    public SaveData InitData()
    {
        SaveData saveData = new SaveData();

        /*
        saveData.collection = 0;
        saveData.usedMoney = 0;
        */

        Save(saveData);
        return saveData;
    }

    //データをセーブする関数
    public void Save(SaveData saveData)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(saveData);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        Debug.Log("保存された");
        writer.Flush();
        writer.Close();
    }


    //セーブされたデータをロードする関数
    public SaveData Load()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "/savedata.json");
        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<SaveData>(datastr);
    }
}
