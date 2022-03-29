//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
//obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
//resultados:
//• Si los tres dados son seis, mostrar el mensaje “Excelente”
//• Si dos dados son seis, mostrar el mensaje “Muy bien”
//• Si un dado es seis, mostrar el mensaje “Regular”
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    int dado1;
    int dado2;
    int dado3;
    // Start is called before the first frame update
    void Start()
    {
        dado1 = Random.Range(1, 7);
        dado2 = Random.Range(1, 7);
        dado3 = Random.Range(1, 7);

        Debug.Log(dado1 + " " + dado2+ " " + dado3);

        if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Excelente");
        }
        if (dado1 != 6 && dado2 == 6 && dado3 == 6 || dado1 == 6 && dado2 != 6 && dado3 == 6 || dado1 == 6 && dado2 == 6 && dado3 != 6)
        {
            Debug.Log("Muy bien");
        }
        if (dado1 == 6 && dado2 != 6 && dado3 != 6 || dado1 != 6 && dado2 == 6 && dado3 != 6 || dado1 != 6 && dado2 != 6 && dado3 == 6)
        {
            Debug.Log("Regular");
        }
        if (dado1 != 6 && dado2 != 6 && dado3 != 6)
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
