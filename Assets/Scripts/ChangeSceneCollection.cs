using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeSceneCollection : MonoBehaviour
{

    public void OntSelect_Dog()
    {
        SceneManager.LoadScene("DogCollection");
    }

    public void OntSelect_Cat()
    {
        SceneManager.LoadScene("CatCollection");
    }

    public void OntSelect_Bird()
    {
        SceneManager.LoadScene("BirdCollection");
    }

    public void OntSelect_Reptiles()
    {
        SceneManager.LoadScene("ReptilesCollection");
    }

    public void OntSelect_Original()
    {
        SceneManager.LoadScene("OriginalCollection");
    }

    public void OntSelect_BackCollection()
    {
        SceneManager.LoadScene("CollectionScene");
    }

}
