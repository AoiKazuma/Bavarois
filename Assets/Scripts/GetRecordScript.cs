using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRecordScript : MonoBehaviour
{

    // DataManager datamanager =  DataManager.Instance;
    [SerializeField] private SaveData saveData;
    public void onSelect_First(){
        SaveData saveData = DataManager.instance.Load();
        // Debug.Log(saveData.log_list.Count);
        int sum=0;
        for  (int r=0; r<saveData.log_list.Count; r++){
            sum += saveData.log_list[r].amount;
        }
        Debug.Log(sum);
    }
}
