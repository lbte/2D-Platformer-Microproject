using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script to play the audio when triggered by the player
/// Code retrieved from: https://www.youtube.com/watch?v=yE0JdtVTnVk
/// </summary>
public class AudioTrigger : MonoBehaviour
{
    private AudioSource phographAudio;

    void Start()
    {
        phographAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D playerCollision)
    {
        if (playerCollision.gameObject.name == "Player")
        {
            phographAudio.Play();
        }
        
    }
}
