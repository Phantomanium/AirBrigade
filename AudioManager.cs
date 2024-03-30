using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds = null;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
