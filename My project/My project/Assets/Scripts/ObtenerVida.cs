using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Audio;

public class ObtenerVida : MonoBehaviour
{
    BarraVida playerVida;
    public AudioSource AudioMoneda;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        playerVida =
       GameObject.FindWithTag("Player").GetComponent<BarraVida>();
        if (other.CompareTag("curas"))
        {
            //AudioMoneda.Play();
            playerVida.vidaActual += 20;
            Destroy(other.gameObject);
        }
    }

}
