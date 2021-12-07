using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SendMoneyLog : MonoBehaviour
{
    GameObject Manager;
    ManagerScript script;
    // public int date;
    public int yyyy;
    public int mm;
    public int dd;
    public int amount;
    public int type;

    void Start(){
    Manager = GameObject.Find("Manager");
    script = Manager.GetComponent<ManagerScript>();
    }

    //Enterが押された時のする処理
    public void onSelect_Enter(){
        //現在時刻の取得
        DateTime click_time = DateTime.Now;
        // date = int.Parse(click_time.Year.ToString() + click_time.Month.ToString() + click_time.Day.ToString());
        yyyy = int.Parse(click_time.Year.ToString());
        mm = int.Parse(click_time.Month.ToString());
        dd = int.Parse(click_time.Day.ToString());
        amount = script.Amount;
        type = script.Category_Type;
        //logのインスタンスを作成
        // Log log = new Log{date=date, amount=amount, type=type};
        Log log = new Log{yyyy=yyyy, mm=mm, dd=dd, amount=amount, type=type};
        //まずは現在のJSONファイルを読み込む
        SaveData saveData = DataManager.instance.Load();
        //log_listにlogの新規追加
        saveData.log_list.Add(log);
        // ticket数の変更
        if (type==0){
            saveData.ticket_dog +=1;
        }
        else if (type==1){
            saveData.ticket_cat +=1;
        }
         else if (type==2){
            saveData.ticket_bird +=1;
        }
         else if (type==3){
            saveData.ticket_reptiles +=1;
        }
        else{
            saveData.ticket_original +=1;
        }
        // 上書き保存
        DataManager.instance.Save(saveData);
        
        


    }
    
}
