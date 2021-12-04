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


    //�f�[�^�̏������B��{�I�ɂ͎g��Ȃ����A������Ԃɖ߂��ăe�X�g�v���C�������Ƃ��Ƃ��L��
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

    //�f�[�^���Z�[�u����֐�
    public void Save(SaveData saveData)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(saveData);

        writer = new StreamWriter(Application.dataPath + "/savedata.json", false);
        writer.Write(jsonstr);
        Debug.Log("�ۑ����ꂽ");
        writer.Flush();
        writer.Close();
    }


    //�Z�[�u���ꂽ�f�[�^�����[�h����֐�
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
