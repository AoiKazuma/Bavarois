using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnSelectButton : MonoBehaviour
{
    [SerializeField] private Text text;

    public void OnSelect()
    {
        text.text = "ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚Ü‚µ‚½I";
    }
}
