using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip winSound;
    public AudioClip pickupsSound;
    bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickups"))
        {
            other.gameObject.SetActive(false);

        PlaySound(pickupsSound);
        gameOver = true;
         }
}

}
