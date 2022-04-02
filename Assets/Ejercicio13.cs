//13.Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
//manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar
//el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public int horas;
    int Pago16;
    int Pago20;
    int salario1;
    int salario2;
    int horasExtra;
   
    // Start is called before the first frame update
    void Start()
    {
        Pago16 = 16;
        Pago20 = 20;
      
        if (horas <= 40)
        {
            salario1 = horas * Pago16;
            Debug.Log("El salario que le corresponde es: $" + salario1);
        }
        if (horas > 40)
        {
            horasExtra = horas - 40;
            salario2 = 40 * Pago16 + horasExtra * Pago20;
            Debug.Log("El salario que le corresponde es: $" + salario2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
