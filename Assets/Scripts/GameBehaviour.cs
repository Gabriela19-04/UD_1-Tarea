using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    public Button WinButton;
    private int _itemsCollected = 0;
    private int _playerHP = 10;

    public int MaxItems = 4;
    
    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;


    // Start is called before the first frame update
    public int Items
    {
       
        get { return _itemsCollected; }
        
        set
        {
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);

            ItemText.text = "Items Collected: " + Items;
            
            if (_itemsCollected >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";
                WinButton.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected)
                + " more!";
            }

        }
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
       
        Time.timeScale = 1f;
    }

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);

            HealthText.text = "Player Health: " + HP;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }
    
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
