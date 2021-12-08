using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 
public class GraphScript : MonoBehaviour
{
   [SerializeField]
   private GameObject content;
   [SerializeField]
   private GameObject graphBar;
   private GameObject[] instances = new GameObject[100];
   //Dropdownを格納する変数
   [SerializeField] 
   private Dropdown dropdown;

   private int i;
   private float max = 0.0f;
   public int target_yyyy;
   public int mm;
   //DateTimeを使うため変数を設定
    DateTime TodayNow;
   
   // Start is called before the first frame update
   void Start()
   {
       SaveData saveData = DataManager.instance.Load();
       //月ごとの合計をあらわした配列を作成する
       float[] monthly_sums = new float[]{0,0,0,0,0,0,0,0,0,0,0,0};
       for  (int r=0; r<saveData.log_list.Count; r++){
            if (saveData.log_list[r].yyyy==target_yyyy){
                monthly_sums[saveData.log_list[r].mm -1 ] += saveData.log_list[r].amount;
            }
        }
        for  (int i=1; i<=12; i++){
            if (max<=monthly_sums[i-1]){
                max = monthly_sums[i-1];
            }
        }
        for  (int i=1; i<=12; i++){
            float xValue = monthly_sums[i-1]/max;
            //graphBar の生成
            instances[i] = Instantiate<GameObject>(graphBar);
            instances[i].transform.SetParent(content.transform);
            instances[i].name = "Data" + i;  //Objectの名前の変更
            //bar の長さの変更
            GameObject bar = GameObject.Find("Data" + i);  //生成したBarを見つける
            bar.GetComponent<Slider>().value = (float)xValue;  //intであればfloatに変換する
            // X_LavelをText に出力
            GameObject x_lavel = bar.gameObject.transform.Find("Background/X_Lavel").gameObject;  //X_Lavelを見つける
            x_lavel.GetComponent<Text>().text = i + "月";
            //DataをText に出力
            if (xValue >= 0.1){  //どちらのTextに出力するかifで分岐
                GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/Data").gameObject;
                data.GetComponent<Text>().text = ""+monthly_sums[i-1];
            }
            else{
                GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/DataUp").gameObject;
                data.GetComponent<Text>().text = ""+monthly_sums[i-1];
            }
        }
   }

    void Remake(){
        SaveData saveData = DataManager.instance.Load();
        float[] monthly_sums = new float[]{0,0,0,0,0,0,0,0,0,0,0,0};

        for(int r=0; r<saveData.log_list.Count; r++){
            if (saveData.log_list[r].yyyy==target_yyyy){
               monthly_sums[saveData.log_list[r].mm -1 ] += saveData.log_list[r].amount;
            }
        }
        for  (int i=1; i<=12; i++){
            if (max<=monthly_sums[i-1]){
                max = monthly_sums[i-1];
            }
        }
        for  (int i=1; i<=12; i++){
            float xValue = monthly_sums[i-1]/max;
            //graphBar の生成
            instances[i] = Instantiate<GameObject>(graphBar);
            instances[i].transform.SetParent(content.transform);

            //時間を取得--->オブジェクト名にする
            TodayNow = DateTime.Now;
            string tmpstring = TodayNow.Day.ToString()+TodayNow.Day.ToString()+TodayNow.ToString() ;
            instances[i].name =  tmpstring + i;  //Objectの名前の変更

            //bar の長さの変更
            GameObject bar = GameObject.Find(tmpstring + i);  //生成したBarを見つける
            bar.GetComponent<Slider>().value = (float)xValue;  //intであればfloatに変換する
            // X_LavelをText に出力
            GameObject x_lavel = bar.gameObject.transform.Find("Background/X_Lavel").gameObject;  //X_Lavelを見つける
            x_lavel.GetComponent<Text>().text = i + "月";
            //DataをText に出力
            if (xValue >= 0.1){  //どちらのTextに出力するかifで分岐
                GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/Data").gameObject;
                data.GetComponent<Text>().text = ""+monthly_sums[i-1];
            }
            else{
                GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/DataUp").gameObject;
                data.GetComponent<Text>().text = ""+monthly_sums[i-1];
            }
        }
    }


   void Update()
   {
        if(dropdown.value==0)
        {
            target_yyyy = 2021;
        }
        else if(dropdown.value==1)
        {
            target_yyyy=2020;
        }
        else if (dropdown.value==2)
        {
            target_yyyy=2019;
        }
        else
        {
            target_yyyy=2021;
        }
   }
   
    
}
