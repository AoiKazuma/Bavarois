using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Refresh : MonoBehaviour
{
    [SerializeField]
    private GameObject content;

    public void DESTROY(){
        //子オブジェクトを全部削除
        foreach( Transform n in content.transform ){
            GameObject.Destroy(n.gameObject);
        }

    
    }

}
