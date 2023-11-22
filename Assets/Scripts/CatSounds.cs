using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSounds : MonoBehaviour
{
    private AudioSource catSoundPlayer;
    public AudioClip[] clips;
   /* public int randomIndex;
    public AudioClip randomClip;*/
    // Start is called before the first frame update
    void Start()
    {
        catSoundPlayer = GetComponent<AudioSource>();
      //  randomClip = GetComponent<AudioClip>();
       // randomIndex = Random.Range(0, clips.Length);
      //  randomClip = clips[randomIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
          catSoundPlayer.clip  = clips[Random.Range(0, clips.Length)];
            //  catSoundPlayer.clip = randomClip;
            catSoundPlayer.PlayOneShot(catSoundPlayer.clip);

        }
    }
}
