using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollectionArraySO")]
public class CollectionArraySO : ScriptableObject
{
    public CollectionSO[] dogArray;
    public CollectionSO[] catArray;
    public CollectionSO[] birdArray;
    public CollectionSO[] reptilesArray;
    public CollectionSO[] otherArray;
}
