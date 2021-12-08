using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    PieChart _pie;
    [SerializeField] private SaveData saveData;

    // Start is called before the first frame update
    void Start()
    {
        SaveData saveData = DataManager.instance.Load();
        float[] category_sums = new float[]{0,0,0,0,0};

        for  (int r=0; r<saveData.log_list.Count; r++){
            // Debug.Log(saveData.log_list[r].type);
            category_sums[saveData.log_list[r].type] += saveData.log_list[r].amount;
        }
        _pie.SetPieChartAnimation(category_sums);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
