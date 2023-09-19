using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pasar_nivel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {//Mostrar siguiente escena
         
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);}
    }
}



