using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BaseGraphScript : MonoBehaviour
{
   [SerializeField]
   private GameObject baseContent;
   [SerializeField]
   private GameObject graphBar;
   private GameObject[] instances = new GameObject[100];
   // Start is called before the first frame update
   void Start()
   {
       //棒グラフの値　
       float xValue = 0.5f;
       
       //graphBar の生成
       instances[0] = Instantiate<GameObject>(graphBar);
       instances[0].transform.parent = baseContent.transform;
       instances[0].name = "Base";
           
       //bar の長さの変更
       GameObject bar = GameObject.Find("Base");
       bar.GetComponent<Slider>().value = xValue;  //intであればfloatに変換する
       // X_LavelをText に出力
       GameObject x_lavel = bar.gameObject.transform.Find("Background/X_Lavel").gameObject;
       x_lavel.GetComponent<Text>().text = "Ave";
           
       //DataをText に出力
       if (xValue >= 0.15)  //どちらのTextに出力するかifで分岐
       {
           GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/Data").gameObject;
           data.GetComponent<Text>().text = xValue + "%";
       }
       else
       {
           GameObject data = bar.gameObject.transform.Find("Handle Slide Area/Handle/DataUp").gameObject;
           data.GetComponent<Text>().text = xValue + "%";
       }
   }
   // Update is called once per frame
   void Update()
   {
       
   }
}

