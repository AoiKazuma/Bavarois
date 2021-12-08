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
    private Text category_Text;


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

        GameObject Category_Text = GameObject.Find("Category_Text");
        category_Text = Category_Text.GetComponent<Text>();


    }

    public void OnClickMealButton(){
        script.Category_Type=0;
        shoppingback.enabled = false;
        mealback.enabled = true;
        trafficback.enabled = false;
        fixedcostback.enabled = false;
        otherback.enabled = false;
        category_Text.text = "食事";

    }

    public void OnClickTrafficButton(){
        script.Category_Type=1;
        shoppingback.enabled = false;
        mealback.enabled = false;
        trafficback.enabled = true;
        fixedcostback.enabled = false;
        otherback.enabled = false;
        category_Text.text = "交通";
    }

    public void OnClickShoppingButton(){
        script.Category_Type=2;
        shoppingback.enabled = true;
        mealback.enabled = false;
        trafficback.enabled = false;
        fixedcostback.enabled = false;
        otherback.enabled = false;
        category_Text.text = "買い物";
    }

    public void OnClickFixedcostButton(){
        script.Category_Type=3;
        shoppingback.enabled = false;
        mealback.enabled = false;
        trafficback.enabled = false;
        fixedcostback.enabled = true;
        otherback.enabled = false;
        category_Text.text = "固定費";
    }

    public void OnClickOtherButton(){
        script.Category_Type=4;
        shoppingback.enabled = false;
        mealback.enabled = false;
        trafficback.enabled = false;
        fixedcostback.enabled = false;
        otherback.enabled = true;
        category_Text.text = "その他";
    }
}
