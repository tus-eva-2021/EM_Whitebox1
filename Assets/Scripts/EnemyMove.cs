using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public class EnemyMove : MonoBehaviour
{
    public Transform goal;
    public NavMeshAgent catSpeed;
    float speed = 2f;
    float catIncrease = 0.5f;
    public GameObject Rat;
    public TMP_Text LoseText;
    public Camera LosingScreen;
    public Button Restart;
    public TMP_Text RestartText;
    public Image RestartImage;
    // Start is called before the first frame update
    void Start()
    {
        catSpeed = GetComponent<NavMeshAgent>();
        catSpeed.speed = speed;

        LoseText.enabled = false;
        LosingScreen.enabled = false;
        Restart.enabled = false;
        RestartText.enabled = false;
        RestartImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoveStart();
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void MoveStart()
    {
        if(Interaction.Instance.cheese >= 1) {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;

        }
    }
    public void SpeedIncrease()
    {
        catSpeed.speed += catIncrease;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Rat.SetActive(false);
            LoseText.enabled = true;
            LosingScreen.enabled = true;
            Restart.enabled = true;
            RestartText.enabled = true;
            RestartImage.enabled = true;
            

        }
    }
}
