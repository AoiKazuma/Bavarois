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

    [SerializeField] private GameObject gameObject_1;
    
    private Text shoppingPer;
    private Text mealPer;
    private Text trafficPer;
    private Text fixedPer;
    private Text otherPer;
    private int sum=0;
    // public int target_yyyy;
    public int gameObject_1_yyyy;

    // Start is called before the first frame update
    void Start()
    {
        gameObject_1_yyyy = gameObject_1.GetComponent<GraphScript>().target_yyyy;

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

        Debug.Log(gameObject_1_yyyy);
        for (int r=0; r<saveData.log_list.Count; r++){
            if (saveData.log_list[r].yyyy==gameObject_1_yyyy){
                category_sums[saveData.log_list[r].type] += saveData.log_list[r].amount;
                sum += saveData.log_list[r].amount;
            }
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

    public void Retest(){
        gameObject_1_yyyy = gameObject_1.GetComponent<GraphScript>().target_yyyy;
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

        Debug.Log(gameObject_1_yyyy);
        for (int r=0; r<saveData.log_list.Count; r++){
            if (saveData.log_list[r].yyyy==gameObject_1_yyyy){
                category_sums[saveData.log_list[r].type] += saveData.log_list[r].amount;
                sum += saveData.log_list[r].amount;
            }
        }

        shoppingPer.text = Math.Round(((double)category_sums[0]/(double)sum)*100) + "%";
        mealPer.text = Math.Round(((double)category_sums[1]/(double)sum)*100) + "%" ;
        trafficPer.text = Math.Round(((double)category_sums[2]/(double)sum)*100) + "%" ;
        fixedPer.text = Math.Round(((double)category_sums[3]/(double)sum)*100) + "%" ;
        otherPer.text = Math.Round(((double)category_sums[4]/(double)sum)*100) + "%"  ;

        _pie.SetPieChartAnimation(category_sums);
    }
}
