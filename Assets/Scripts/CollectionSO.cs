using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectionSO")]
public class CollectionSO : ScriptableObject
{
    public string collectionName;
    public Sprite image;
    //Å´maybe not necessary...
    /*
    public int index;
    public enum Category
    {
        dog,
        cat,
        bird,
        reptiles,
        other
    }
    public Category category;
    */
}
