using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    public int ticket_dog = 0;
    public int ticket_cat = 0;
    public int ticket_bird = 0;
    public int ticket_reptiles = 0; 
    public int ticket_original = 0;

    public int[] collection_dog = new int[]{0,0,0,0,0};
    public int[] collection_cat = new int[]{0,0,0,0,0};
    public int[] collection_bird = new int[]{0,0,0,0,0};
    public int[] collection_reptiles = new int[]{0,0,0,0,0};
    public int[] collection_original = new int[]{0,0,0,0,0};

    public List<Log> log_list = new List<Log>();
    
}