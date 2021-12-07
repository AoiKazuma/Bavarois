using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    [SerializeField] private CollectionArraySO collectionArray;

    // Start is called before the first frame update
    void Start()
    {
        //load save data
        SaveData saveData = DataManager.instance.Load();

        int index = GenerateCollectionIndex();

        //選んだガチャのカテゴリに応じて処理を分ける
        switch (DataManager.instance.selectedCategoryForGacha)
        {
            case 0:
                saveData.ticket_dog--;
                saveData.collection_dog[index] = 1;
                DataManager.instance.Save(saveData);
                Debug.Log($"{collectionArray.dogArray[index].collectionName}をゲットした！");
                break;
            case 1:
                saveData.ticket_cat--;
                saveData.collection_cat[index] = 1;
                DataManager.instance.Save(saveData);
                Debug.Log($"{collectionArray.catArray[index].collectionName}をゲットした！");
                break;
            case 2:
                saveData.ticket_bird--;
                saveData.collection_bird[index] = 1;
                DataManager.instance.Save(saveData);
                Debug.Log($"{collectionArray.birdArray[index].collectionName}をゲットした！");
                break;
            case 3:
                saveData.ticket_reptiles--;
                saveData.collection_reptiles[index] = 1;
                DataManager.instance.Save(saveData);
                Debug.Log($"{collectionArray.reptilesArray[index].collectionName}をゲットした！");
                break;
            case 4:
                saveData.ticket_original--;
                saveData.collection_original[index] = 1;
                DataManager.instance.Save(saveData);
                Debug.Log($"{collectionArray.originalArray[index].collectionName}をゲットした！");
                break;
        }
    }

    private int GenerateCollectionIndex()
    {
        int randomInt = Random.Range(0, 100);
        if (0 <= randomInt && randomInt < 30)
        {
            return 0;
        }
        else if (30 <= randomInt && randomInt < 60)
        {
            return 1;
        }
        else if (60 <= randomInt && randomInt < 75)
        {
            return 2;
        }
        else if (75 <= randomInt && randomInt < 90)
        {
            return 3;
        }
        else
        {
            return 4;
        }
    }

    
}
