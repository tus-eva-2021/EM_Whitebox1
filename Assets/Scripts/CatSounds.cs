using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    public AudioSource catSoundPlayer;
    public AudioClip[] clips;
    [Range(0.1f, 0.5f)]
    public float randomVolume = 0.2f;
    [Range(0.1f, 0.5f)]
    public float randomPitch = 0.2f;
    public float minWait;
    public float maxWait;


    private void Start()
    {
        catSoundPlayer = GetComponent<AudioSource>();
        StartCoroutine("startPlayingSounds");
    }
    private void Update()
    {
    }
    public void RandomNoises()
    {
        AudioClip randomClip = clips[Random.Range(0, clips.Length)];
        catSoundPlayer.volume = Random.Range(1 - randomVolume, 1);
        catSoundPlayer.volume = Random.Range(1 - randomPitch, 1 + randomPitch);
        catSoundPlayer.PlayOneShot(randomClip);
    }
    IEnumerator startPlayingSounds()
    {
        while (true)
        {
            RandomNoises();
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));
        }

    }
}