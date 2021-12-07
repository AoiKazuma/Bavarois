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
    private string[] categoryArray = new string[] { "哺乳類", "昆虫", "鳥類", "海の生き物", "シークレット" };

    public Image birdback;
    public Image catback;
    public Image dogback;
    public Image originalback;
    public Image reptilesback;

    private void Start()
    {
        GameObject ExecuteButton = GameObject.Find("ExecuteButton");
        GameObject TicketNumText = GameObject.Find("TicketNumText");
        GameObject SelectedCategoryText = GameObject.Find("SelectedCategoryText");
        executeButton = ExecuteButton.GetComponent<Button>();
        ticketNumText = TicketNumText.GetComponent<Text>();
        selectedCategoryText = SelectedCategoryText.GetComponent<Text>();

        birdback = GameObject.Find("BirdBack").GetComponent<Image>();
        birdback.enabled = false;
        catback = GameObject.Find("CatBack").GetComponent<Image>();
        catback.enabled = false;
        dogback = GameObject.Find("DogBack").GetComponent<Image>();
        dogback.enabled = false;
        originalback = GameObject.Find("OriginalBack").GetComponent<Image>();
        originalback.enabled = false;
        reptilesback = GameObject.Find("ReptilesBack").GetComponent<Image>();
        reptilesback.enabled = false;


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
        //UI�ؑ�
        selectedCategoryText.text = categoryArray[categoryID];

        //�`�P�b�g���\��
        ticketNumText.text = $"残りチケット数：{ticket}";

        //�`�P�b�g������΃K�`���ɐi�߂�悤�ɂ���
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;
            Debug.Log($"�I�����ꂽ�J�e�S���[�F{categoryArray[categoryID]}");
            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }
    }
    public void OnClickBirdButton(){
        // 背景選択
        birdback.enabled = true;
        catback.enabled = false;
        dogback.enabled = false;
        originalback.enabled = false;
        reptilesback.enabled = false;
        selectedCategoryText.text = categoryArray[categoryID];
        //�`�P�b�g���\��
        ticketNumText.text = $"残りチケット数：{ticket}";

        //�`�P�b�g������΃K�`���ɐi�߂�悤�ɂ���
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;

            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }

    }

    public void OnClickCatButton(){
        // 背景選択
        birdback.enabled = false;
        catback.enabled = true;
        dogback.enabled = false;
        originalback.enabled = false;
        reptilesback.enabled = false;
        selectedCategoryText.text = categoryArray[categoryID];
        //�`�P�b�g���\��
        ticketNumText.text = $"残りチケット数：{ticket}";

        //�`�P�b�g������΃K�`���ɐi�߂�悤�ɂ���
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;
            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }

    }

    public void OnClickDogButton(){
        // 背景選択
        birdback.enabled = false;
        catback.enabled = false;
        dogback.enabled = true;
        originalback.enabled = false;
        reptilesback.enabled = false;
        selectedCategoryText.text = categoryArray[categoryID];
        //�`�P�b�g���\��
        ticketNumText.text = $"残りチケット数：{ticket}";

        //�`�P�b�g������΃K�`���ɐi�߂�悤�ɂ���
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;
            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }

    }

    public void OnClickOriginalButton(){
        // 背景選択
        birdback.enabled = false;
        catback.enabled = false;
        dogback.enabled = false;
        originalback.enabled = true;
        reptilesback.enabled = false;
        selectedCategoryText.text = categoryArray[categoryID];
        //�`�P�b�g���\��
        ticketNumText.text = $"残りチケット数：{ticket}";

        //�`�P�b�g������΃K�`���ɐi�߂�悤�ɂ���
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;
            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }

    }

    public void OnClickReptilesButton(){
        // 背景選択
        birdback.enabled = false;
        catback.enabled = false;
        dogback.enabled = false;
        originalback.enabled = false;
        reptilesback.enabled = true;
        selectedCategoryText.text = categoryArray[categoryID];
        //�`�P�b�g���\��
        ticketNumText.text = $"残りチケット数：{ticket}";

        //�`�P�b�g������΃K�`���ɐi�߂�悤�ɂ���
        if (ticket > 0)
        {
            DataManager.instance.selectedCategoryForGacha = categoryID;
            executeButton.interactable = true;
        }
        else
        {
            executeButton.interactable = false;
        }

    }
}
