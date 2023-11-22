using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public EnemyMove catSpeed;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Interaction.Instance.AddCheese();
            Destroy(this.gameObject);
           catSpeed.SpeedIncrease();
         
        }
        
    }
}
