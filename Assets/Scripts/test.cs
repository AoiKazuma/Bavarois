using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField]
    PieChart _pie;
    [SerializeField] private SaveData saveData;
    
    private Text shoppingPer;
    private Text mealPer;
    private Text trafficPer;
    private Text fixedPer;
    private Text otherPer;
    private int sum=0;

    // Start is called before the first frame update
    void Start()
    {
        SaveData saveData = DataManager.instance.Load();
        float[] category_sums = new float[]{0,0,0,0,0};

        GameObject ShoppingPer = GameObject.Find("ShoppingPer");
        shoppingPer = ShoppingPer.GetComponent<Text>();
        GameObject MealPer = GameObject.Find("MealPer");
        mealPer = MealPer.GetComponent<Text>();
        GameObject TrafficPer = GameObject.Find("TrafficPer");
        trafficPer = TrafficPer.GetComponent<Text>();
        GameObject FixedPer = GameObject.Find("FixedPer");
        fixedPer = FixedPer.GetComponent<Text>();
        GameObject OtherPer = GameObject.Find("OtherPer");
        otherPer = OtherPer.GetComponent<Text>();


        for  (int r=0; r<saveData.log_list.Count; r++){
            // Debug.Log(saveData.log_list[r].type);
            category_sums[saveData.log_list[r].type] += saveData.log_list[r].amount;
            sum += saveData.log_list[r].amount;
        }
        shoppingPer.text = Math.Round(((double)category_sums[0]/(double)sum)*100) + "%";
        mealPer.text = Math.Round(((double)category_sums[1]/(double)sum)*100) + "%" ;
        trafficPer.text = Math.Round(((double)category_sums[2]/(double)sum)*100) + "%" ;
        fixedPer.text = Math.Round(((double)category_sums[3]/(double)sum)*100) + "%" ;
        otherPer.text = Math.Round(((double)category_sums[4]/(double)sum)*100) + "%"  ;

        _pie.SetPieChartAnimation(category_sums);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
