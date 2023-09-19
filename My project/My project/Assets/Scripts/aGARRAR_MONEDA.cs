using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aGARRAR_MONEDA : MonoBehaviour
{
    public Text puntos;
    public int moneda;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = moneda.ToString();
    }

    public void agarrar()
    {
        moneda += 100;
    }

}
