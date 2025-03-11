using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource WalkingSounds;
    public AudioSource ShootingSounds;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            PlayMovementSound();
        }
    }

    public void PlayMovementSound()
    {
        if (WalkingSounds.isPlaying == false)
        {
            print("play walking");
            WalkingSounds.Play();
        }
    }
}
