using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    private AudioSource explosionAudio;
    public AudioClip explosionSound;

    // Start is called before the first frame update
    void Start()
    {
        explosionAudio = GetComponent<AudioSource>();
    }

    public void PlayExplosion()
    {
        explosionAudio.PlayOneShot(explosionSound,1.0f);
    }
}
