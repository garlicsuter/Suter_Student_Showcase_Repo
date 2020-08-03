using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proximity_Narration : MonoBehaviour
{
    public AudioSource narration;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !narration.isPlaying)
        {
            narration.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && narration.isPlaying)
        {
            narration.Stop();
        }
    }
}
