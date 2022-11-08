using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Emanuil Filipov
public class PlaySpecificAudio : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip myAudioClip1;
    [SerializeField] private float volume = 1.0f;
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.PlayOneShot(myAudioClip1, volume);
            }
            else
            {
                myAudioSource.Pause();
                myAudioSource.Play();
            }
        }
    }
}
