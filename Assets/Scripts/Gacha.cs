using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    [SerializeField] private CollectionArraySO collectionArray;
    [SerializeField] private Image collectionImage;
    [SerializeField] private Text collectionNameText;
    [SerializeField] private Text rarelityText;
    [SerializeField] private ParticleSystem particle;


    // Start is called before the first frame update
    void Start()
    {
        //load save data
        SaveData saveData = DataManager.instance.Load();

        int index = GenerateCollectionIndex();
        rarelityText.text = GetRarelity(index);

        var emission = particle.emission;
        emission.rateOverTime = ParticleRate(index);

        //選んだガチャのカテゴリに応じて処理を分ける
        switch (DataManager.instance.selectedCategoryForGacha)
        {
            case 0:
                saveData.ticket_dog--;
                saveData.collection_dog[index] = 1;
                DataManager.instance.Save(saveData);
                collectionImage.sprite = collectionArray.dogArray[index].image;
                collectionNameText.text = collectionArray.dogArray[index].collectionName;
                Debug.Log($"{collectionArray.dogArray[index].collectionName}をゲットした！");
                break;
            case 1:
                saveData.ticket_cat--;
                saveData.collection_cat[index] = 1;
                DataManager.instance.Save(saveData);
                collectionImage.sprite = collectionArray.catArray[index].image;
                collectionNameText.text = collectionArray.catArray[index].collectionName;
                Debug.Log($"{collectionArray.catArray[index].collectionName}をゲットした！");
                break;
            case 2:
                saveData.ticket_bird--;
                saveData.collection_bird[index] = 1;
                DataManager.instance.Save(saveData);
                collectionImage.sprite = collectionArray.birdArray[index].image;
                collectionNameText.text = collectionArray.birdArray[index].collectionName;
                Debug.Log($"{collectionArray.birdArray[index].collectionName}をゲットした！");
                break;
            case 3:
                saveData.ticket_reptiles--;
                saveData.collection_reptiles[index] = 1;
                DataManager.instance.Save(saveData);
                collectionImage.sprite = collectionArray.reptilesArray[index].image;
                collectionNameText.text = collectionArray.reptilesArray[index].collectionName;
                Debug.Log($"{collectionArray.reptilesArray[index].collectionName}をゲットした！");
                break;
            case 4:
                saveData.ticket_original--;
                saveData.collection_original[index] = 1;
                DataManager.instance.Save(saveData);
                collectionImage.sprite = collectionArray.originalArray[index].image;
                collectionNameText.text = collectionArray.originalArray[index].collectionName;
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

    private string GetRarelity(int index)
    {
        if (index == 0 || index == 1)
        {
            return "★☆☆";
        }
        else if(index == 2 || index == 3)
        {
            return "★★☆";
        }
        else
        {
            return "★★★";
        }
    }

    private float ParticleRate(int index)
    {
        if (index == 0 || index == 1)
        {
            return 5.0f;
        }
        else if (index == 2 || index == 3)
        {
            return 7.0f;
        }
        else
        {
            return 12.0f;
        }
    }
}
