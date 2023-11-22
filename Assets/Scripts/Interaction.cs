using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{   [SerializeField] public int cheese;
    [SerializeField] public int digs;
  
    private static Interaction _instance;

    public static Interaction Instance 
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

    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        cheese = 0; 
        digs = 0;
        Cursor.lockState = CursorLockMode.Locked;

        
    }

    // Update is called once per frame
    void Update()
    {
        UIManager.Instance.UpdateCheeseText(cheese);
        UIManager.Instance.UpdateDigsText(digs);

        
    }
    public void AddCheese()
    {
        cheese += 1;
        digs += 1;
    }
   
            public void Break()
    {
        if (Interaction.Instance.digs >= 1)
        {
            digs -= 1;
        }
       
    }
   
}
