using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource walkingSounds;
    //public AudioSource shootSounds; Add this later
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            PlayMovementSound();
        }
    }

    public void PlayMovementSound()
    {
        if (walkingSounds.isPlaying == false)
        {
            walkingSounds.Play();
        }
    }
}
