using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DigAction : MonoBehaviour
{
    public Interaction dig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (UnityEngine.Input.GetButton("Dig") && Interaction.Instance.digs >= 1)
        {
            dig.Break();
            Destroy(gameObject);

        }
    }
}
