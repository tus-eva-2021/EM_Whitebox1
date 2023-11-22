using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.AI;

public class UIManager : MonoBehaviour
{
    public TMP_Text cheeseText;
    public TMP_Text digsText;
    public TMP_Text winText;
    public Interaction player;
    private static UIManager _instance;
   
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Player is null");
            }
            return _instance;
        }
    }
    void Start()
    {
        winText.enabled = false;
    }
    private void Awake()
    {
        _instance = this;
    }
    void Update()
    {
       if (Interaction.Instance.cheese >= 10)
    {
            winText.enabled = true;
        }
    }
   
    public void UpdateCheeseText(int cheese)
    {
        cheeseText.text = "Cheese: " + cheese;
    }
    public void UpdateDigsText(int digs)
    {
        digsText.text = "Digs: " + digs;
    }
    public void NewGameButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
