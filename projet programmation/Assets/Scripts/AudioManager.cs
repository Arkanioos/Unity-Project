using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioMixerGroup audioMixerGroup;
    public Sound[] sounds;
    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.outputAudioMixerGroup = audioMixerGroup;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(string argName)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == argName);
        s.source.Play();
    }

}
