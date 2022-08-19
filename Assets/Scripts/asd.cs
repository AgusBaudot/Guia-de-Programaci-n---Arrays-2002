using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    [SerializeField] string[] meses = new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
    [SerializeField] int[] dias = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    [SerializeField] string FechaIngresada;

    // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(FechaIngresada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;
        string dia;
        string mes;
        if(fecha.Length == 4)
        {
            dia = "";
            dia += fecha[0];
            dia += fecha[1];
            int diaNumber = int.Parse(dia);
            mes = "";
            mes += fecha[2];
            mes += fecha[3];
            int.Parse(mes);
            int mesNumber = int.Parse(mes);
            if(diaNumber>0 && diaNumber <= 31 && mesNumber > 0 && mesNumber <= 12)
            {
                fechaValida = true;
            }
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto");
        }
        return fechaValida;
    }
}
