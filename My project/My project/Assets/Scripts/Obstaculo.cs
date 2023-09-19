using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

public class Obstaculo : MonoBehaviour
{
    BarraVida playerVida;
    //public AudioSource AudioObstaculo;
    public void OnCollisionEnter(Collision collision)
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<BarraVida>();
        //Cuando el elemento Tag llamado Player colisiona
        if (collision.transform.CompareTag("Player"))
        {
            //AudioObstaculo.Play();
           // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Regresar la esfera a su posición inicial
            GameObject.FindWithTag("Player").transform.position = new
            Vector3(0, (float)1.18, 0);
            playerVida.vidaActual -= 20;
            //Cuando la barra de vida llegue a 0
            if (playerVida.vidaActual == 0)
            {
                //Carga la escena de Game Over
                SceneManager.LoadScene(5);
            }

        }
    }
}
