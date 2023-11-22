using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CatSounds : MonoBehaviour
{
    public AudioSource catSoundPlayer;
    public AudioClip[] clips;
    [Range(0.1f, 0.5f)]
    public float randomVolume = 0.2f;
    public float randomPitch = 0.2f;
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
    public void randomNoises()
    {
        catSoundPlayer.clip = clips[Random.Range(0, clips.Length)];
        catSoundPlayer.volume = Random.Range(1 - randomVolume, 1);
        catSoundPlayer.pitch = Random.Range(1 - randomPitch, 1 + randomPitch);
        //  catSoundPlayer.clip = randomClip;
        catSoundPlayer.PlayOneShot(catSoundPlayer.clip);

    }
}
