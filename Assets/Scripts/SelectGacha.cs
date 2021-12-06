using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectGacha : MonoBehaviour
{
    [SerializeField] private int categoryID;
    private Button executeButton;
    private Text ticketNumText;
    private Text selectedCategoryText;
    private SaveData saveData;
    private int ticket;
    private string[] categoryArray = new string[] { "犬", "猫", "鳥", "爬虫類", "オリジナル" };

    private void Start()
    {
        GameObject ExecuteButton = GameObject.Find("ExecuteButton");
        GameObject TicketNumText = GameObject.Find("TicketNumText");
        GameObject SelectedCategoryText = GameObject.Find("SelectedCategoryText");
        executeButton = ExecuteButton.GetComponent<Button>();
        ticketNumText = TicketNumText.GetComponent<Text>();
        selectedCategoryText = SelectedCategoryText.GetComponent<Text>();


        saveData = DataManager.instance.Load();
        switch (categoryID)
        {
            case 0:
                ticket = saveData.ticket_dog;
                break;
            case 1:
                ticket = saveData.ticket_cat;
                break;
            case 2:
                ticket = saveData.ticket_bird;
                break;
            case 3:
                ticket = saveData.ticket_reptiles;
                break;
            default:
                ticket = saveData.ticket_original;
                break;
        }
    }
    public void OnSelectGachaButton()
    {
        //UI切替
        selectedCategoryText.text = categoryArray[categoryID];

        //チケット数表示
        ticketNumText.text = $"残りチケット数：{ticket}";

        //チケットがあればガチャに進めるようにする
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;
            Debug.Log($"選択されたカテゴリー：{categoryArray[categoryID]}");
            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }
    }
}
