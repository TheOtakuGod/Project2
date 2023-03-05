using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip winSound;
    public AudioClip loseSound;
    public AudioClip pickupsSound;
    public AudioClip starterSound;
    AudioSource audioSource;
    bool gameOver;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(starterSound);

         ParticleSystem part = GetComponent<ParticleSystem>();
    }


    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            other.gameObject.SetActive(false);

        PlaySound(pickupsSound);
        gameOver = true;
        audioSource.PlayOneShot(winSound);

        var part = GetComponent<ParticleSystem>();
        part.Play();
        Destroy(gameObject); 
         
        }

    }



    void Update()
    {

    }
}
