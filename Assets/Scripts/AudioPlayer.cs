using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip AudioClip;
    public AudioClip AudioClip2;
    public AudioClip Background;
    [Min(0)]
    public float Volume;

    private AudioSource Audio;

    private void Awake()
    {
        Audio = GetComponent<AudioSource>();
        TakeFoodAudio();
    }

    public void PlayAudio()
    {
        Audio.Play();
    }

    public void TakeFoodAudio()
    {
        Audio.PlayOneShot(AudioClip);
    }

    public void DestroyBlock()
    {
        Audio.PlayOneShot(AudioClip2);
    }

    private void OnEnable()
    {
        Audio.PlayOneShot(Background, Volume);
    }

    private void OnDisable()
    {
        Audio.Stop();
    }
}
