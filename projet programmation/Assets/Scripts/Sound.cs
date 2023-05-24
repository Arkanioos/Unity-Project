using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public AudioClip clip;

    public string Name;

    [HideInInspector]
    public AudioSource source;
}
