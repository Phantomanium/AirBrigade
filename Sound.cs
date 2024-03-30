using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    [HideInInspector]
    public AudioSource source = null;
    public AudioClip clip = null;
    public string name = null;

    [Range(0f, 1f)]
    public float volume = 1f;
    [Range(.1f, 3f)]
    public float pitch = 1f;

    public bool loop = false;

}
