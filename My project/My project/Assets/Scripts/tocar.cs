using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class tocar : MonoBehaviour
{
    public AudioSource quienEmite;
    public AudioClip elSonido;
    public float volumen = 1f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            quienEmite.Play();
        }
    }

    /*rivate void OnTriggerEnter(Collision )
    {
        quienEmite.PlayOneShot(elSonido, volumen);
    }*/
}
