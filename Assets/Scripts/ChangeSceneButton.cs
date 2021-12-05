using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeSceneButton : MonoBehaviour
{

    public void OntSelect_Start()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void OnSElect_Record()
    {
        SceneManager.LoadScene("RecordScene");
    }

    public void OntSelect_Buck()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void OntSelect_Gacha()
    {
        SceneManager.LoadScene("GachaScene");
    }

    public void OntSelect_Play()
    {
        SceneManager.LoadScene("GachaGetScene");
    }

    public void OntSelect_Collection()
    {
        SceneManager.LoadScene("CollectionScene");
    }

}
