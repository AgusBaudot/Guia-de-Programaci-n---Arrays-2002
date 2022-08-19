using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_Puntajes : MonoBehaviour
{
    [SerializeField] int[] puntajes = new int[10];
    //ObtenerNivelDeMenorPuntaje()

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ObtenerMayorPuntaje());
        Debug.Log(ObtenerNivelDeMenorPuntaje());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int ObtenerMayorPuntaje()
    {
        int mayor = 0;
        foreach (int n in puntajes)
        {
            if (n > mayor)
            {
                mayor = n;
            }
        }
        return mayor;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int nivel = 1;
        int menor = puntajes[0];
        for (int i = 0; i < puntajes.Length; i++)
        {
            if (puntajes[i] < menor)
            {
                menor = puntajes[i];
                nivel = i;
            }
        }
        return nivel;
    }

    float ObtenerPuntajePromedio()
    {
        float total = 0;
        float promedio;

        for (int i = 0; i < puntajes.Length; i++)
        {
            total += puntajes[i];
        }

        promedio = total / puntajes.Length;

        return promedio;
    }

}
