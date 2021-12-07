using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CategoryButton : MonoBehaviour
{
    GameObject Manager;
    ManagerScript script;


    public Image shoppingback;
    public Image mealback;
    public Image trafficback;
    public Image fixedcostback;
    public Image otherback;


    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<ManagerScript>();

        shoppingback = GameObject.Find("ShoppingBack").GetComponent<Image>();
        shoppingback.enabled = false;
        mealback = GameObject.Find("MealBack").GetComponent<Image>();
        mealback.enabled = false;
        trafficback = GameObject.Find("TrafficBack").GetComponent<Image>();
        trafficback.enabled = false;
        fixedcostback = GameObject.Find("FIxedCostBack").GetComponent<Image>();
        fixedcostback.enabled = false;
        otherback = GameObject.Find("OtherBack").GetComponent<Image>();
        otherback.enabled = false;


    }

    public void OnClickMealButton(){
        script.Category_Type=0;
        shoppingback.enabled = false;
        mealback.enabled = true;
        trafficback.enabled = false;
        fixedcostback.enabled = false;
        otherback.enabled = false;

    }

    public void OnClickTrafficButton(){
        script.Category_Type=1;
        script.Category_Type=0;
        shoppingback.enabled = false;
        mealback.enabled = false;
        trafficback.enabled = true;
        fixedcostback.enabled = false;
        otherback.enabled = false;
    }

    public void OnClickShoppingButton(){
        script.Category_Type=2;
        script.Category_Type=0;
        shoppingback.enabled = true;
        mealback.enabled = false;
        trafficback.enabled = false;
        fixedcostback.enabled = false;
        otherback.enabled = false;
    }

    public void OnClickFixedcostButton(){
        script.Category_Type=3;
        script.Category_Type=0;
        shoppingback.enabled = false;
        mealback.enabled = false;
        trafficback.enabled = false;
        fixedcostback.enabled = true;
        otherback.enabled = false;
    }

    public void OnClickOtherButton(){
        script.Category_Type=4;
        script.Category_Type=0;
        shoppingback.enabled = false;
        mealback.enabled = false;
        trafficback.enabled = false;
        fixedcostback.enabled = false;
        otherback.enabled = true;
    }
}
