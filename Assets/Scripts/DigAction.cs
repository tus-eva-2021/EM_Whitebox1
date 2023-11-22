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
        if (UnityEngine.Input.GetButton("Dig") /*&& GetComponent<BoxCollider>()*/)
        {
            dig.Break();
            Destroy(this);
          //  Destroy(GetComponent<BoxCollider>());

        }
    }
  
}
