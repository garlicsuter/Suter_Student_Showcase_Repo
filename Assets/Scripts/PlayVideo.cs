using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script thanks to Youtube channel "Lurony"
// viewable here: https://www.youtube.com/watch?v=t-wamt3xilA

public class PlayVideo : MonoBehaviour
{

    public GameObject videoPlayer;
    public int timeToStop;

    // Use this for initialization
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {

        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            //Destroy(videoPlayer, timeToStop);
            Debug.Log("Video Player hit player");
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(false);
            Debug.Log("Exit");
        } 
    }
}