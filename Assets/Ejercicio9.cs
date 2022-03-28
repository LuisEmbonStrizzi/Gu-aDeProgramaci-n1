//9.Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ ….

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string Persona1;
    public float Capital1;
    public string Persona2;
    public float Capital2;
    public string Persona3;
    public float Capital3;

    float total;
    float porcentaje1;
    float porcentaje2;
    float porcentaje3;
    // Start is called before the first frame update
    void Start()
    {
        total = Capital1 + Capital2 + Capital3;
        porcentaje1 = Capital1 * 100 / total;
        porcentaje2 = Capital2 * 100 / total;
        porcentaje3 = Capital3 * 100 / total;

        Debug.Log(Persona1 + ":" + " Capital aportado: $" + Capital1 + " ,Porcentaje del capital: %" + porcentaje1);
        Debug.Log(Persona2 + ":" + " Capital aportado: $" + Capital2 + " ,Porcentaje del capital: %" + porcentaje2);
        Debug.Log(Persona3 + ":" + " Capital aportado: $" + Capital3 + " ,Porcentaje del capital: %" + porcentaje3);
        Debug.Log("Monto total aportado: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
