using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DigAction : MonoBehaviour
{
    public Interaction dig;
    public bool colliding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (colliding)
        {
            digging();
        }  
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        colliding = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        colliding = false;
    }
    public void digging()
    {
        if (UnityEngine.Input.GetButton("Dig") && Interaction.Instance.digs >= 1)
        {
            dig.Break();
            Destroy(gameObject);

        }
    }
}
