using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class SoundClass
{
    public string name;
    public AudioClip sound;
    [Range(0.1f, 0.5f)]
    public float volume;
    [Range(0.1f, 0.5f)]
    public float pitch;
}
