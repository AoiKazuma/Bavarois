using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordMoney : MonoBehaviour
{
    public InputField inputField;
    GameObject Manager;
    ManagerScript script;

    void Start()
    {
        inputField = inputField.GetComponent<InputField> ();
        Manager = GameObject.Find("Manager");
        script = Manager.GetComponent<ManagerScript>();
    }

    public void GetAmount(){
        script.Amount = int.Parse(inputField.text);
    }
}
