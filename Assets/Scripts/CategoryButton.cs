using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryButton : MonoBehaviour
{
    GameObject Manager;
    ManagerScript script;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<ManagerScript>();
    }

    public void OnClickMealButton(){
        script.Category_Type=0;
    }

    public void OnClickTrafficButton(){
        script.Category_Type=1;
    }

    public void OnClickShoppingButton(){
        script.Category_Type=2;
    }

    public void OnClickFixedcostButton(){
        script.Category_Type=3;
    }

    public void OnClickOtherButton(){
        script.Category_Type=4;
    }
}
