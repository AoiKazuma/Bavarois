using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ViewOriginal0 : MonoBehaviour
{
    public Image image;

    void Start()
    {
        image = GetComponent<Image>();
        SaveData saveData = DataManager.instance.Load();
    
        if(saveData.collection_original[0]==0){
            image.enabled = false;
        }
        else{
            image.enabled = true;
        }
    }

}
