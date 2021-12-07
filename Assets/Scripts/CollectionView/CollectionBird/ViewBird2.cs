using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ViewBird2 : MonoBehaviour
{
    public Image image;

    void Start()
    {
        image = GetComponent<Image>();
        SaveData saveData = DataManager.instance.Load();
    
        if(saveData.collection_bird[2]==0){
            image.enabled = false;
        }
        else{
            image.enabled = true;
        }
    }

}
