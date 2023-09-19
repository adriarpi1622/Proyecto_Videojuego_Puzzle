using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Esfera : MonoBehaviour
{
    public Text score;
    public Rigidbody rb; 
    public float adelante = 500; //fuerza hacia delante
    public float lado = 500; // fuerza de lado
    // Start is called before the first frame update
    public float empuje = 10;
    //Cuando esfera esta en el plano
    bool m_insGrounded = true;



    void Start()
    {
        Debug.Log("Hola Mundo");
    }

    // Update is called once per frame
    void Update()
    {
        //Ejes x,y,z
        //  rb.AddForce(0, 0, adelante * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, adelante * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -adelante * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(lado * Time.deltaTime, 0,0) ;
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-lado * Time.deltaTime, 0, 0);
        }

        //Para saltar
        if (Input.GetKeyDown(KeyCode.Space) && m_insGrounded == true)
        {
            Jump();
        }

        //Generar puntaje
        //score.text = transform.position.z.ToString("0");
    }



    public void Jump()
    {
        //Ya no esta em el plano
        m_insGrounded = false;
        rb.AddForce(0, empuje, 0, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            //Cuando esfera esta en el plano
            m_insGrounded = true;
        }
    }
}
