using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GraphScript : MonoBehaviour
{
   [SerializeField]
   private GameObject content;
   [SerializeField]
   private GameObject graphBar;
   private GameObject[] instances = new GameObject[100];
   private int i;
   private float max = 0.0f;
   public int target_yyyy=2021;
   public int mm;
   
   // Start is called before the first frame update
   void Start()
   {
       SaveData saveData = DataManager.instance.Load();
       //月ごとの合計をあらわっした配列を作成する
       float[] monthly_sums = new float[]{0,0,0,0,0,0,0,0,0,0,0,0};
       for  (int r=0; r<saveData.log_list.Count; r++){
            if (saveData.log_list[r].yyyy==target_yyyy){
                monthly_sums[saveData.log_list[r].mm -1 ] += saveData.log_list[r].amount;
            }
        }


        // float[] monthly_sums = new float[]{1,2,3,4,5,6,7,8,9,10,11,12};
        for  (int i=1; i<=12; i++){
            if (max<=monthly_sums[i-1]){
                max = monthly_sums[i-1];
            }
        }
        Debug.Log(max);
        for  (int i=1; i<=12; i++){
            float xValue = monthly_sums[i-1]/max;
            //graphBar の生成
            instances[i] = Instantiate<GameObject>(graphBar);
            instances[i].transform.parent = content.transform;
            instances[i].name = "Data" + i;  //Objectの名前の変更
            //bar の長さの変更
            GameObject bar = GameObject.Find("Data" + i);  //生成したBarを見つける
            bar.GetComponent<Slider>().value = xValue;  //intであればfloatに変換する
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
            // i ++;
        }
   }
   // Update is called once per frame
   void Update()
   {
       //クリックした時に呼び出される
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        //棒グラフの値　今回は0~1の乱数
    //        float xValue = Random.value;
       
    //        //graphBar の生成
    //        instances[i] = Instantiate<GameObject>(graphBar);
    //        instances[i].transform.parent = content.transform;
    //        instances[i].name = "Data" + i;  //Objectの名前の変更
           
    //        //bar の長さの変更
    //        GameObject bar = GameObject.Find("Data" + i);  //生成したBarを見つける
    //        bar.GetComponent<Slider>().value = xValue;  //intであればfloatに変換する
    //        // X_LavelをText に出力
    //        GameObject x_lavel = bar.gameObject.transform.Find("Background/X_Lavel").gameObject;  //X_Lavelを見つける
    //        x_lavel.GetComponent<Text>().text = "x_ " + i;
           
    //        //DataをText に出力
    //        if (xValue >= 0.15)  //どちらのTextに出力するかifで分岐
    //        {
    //            GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/Data").gameObject;
    //            data.GetComponent<Text>().text = xValue + "%";
    //        }
    //        else
    //        {
    //            GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/DataUp").gameObject;
    //            data.GetComponent<Text>().text = xValue + "%";
    //        }
       
    //        i ++;
    //    } 


   }
}
