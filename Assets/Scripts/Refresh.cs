using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Refresh : MonoBehaviour
{
    [SerializeField]
    private GameObject content;

    [SerializeField]
    private GameObject gameObject;

    public void DESTROY(){
        //子オブジェクトを全部削除
        foreach( Transform n in content.transform ){
            GameObject.Destroy(n.gameObject);
        }

        foreach( Transform n in gameObject.transform ){
            GameObject.Destroy(n.gameObject);
        }

    
    }

}
