//6.Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
//en una variable llamada num1 y muestre un mensaje por pantalla indicando &quot; el número es
//par&quot; o & quot; el número es impar&quot;. Deberá utilizar el operador “módulo” es el caracter %.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public int num1;
    
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > 0) 
        {
            if(num1 % 2 == 0) 
            {
                Debug.Log("El numero es par");
            }
            else 
            {
                Debug.Log("El numero es impar");
            }
        }
        else 
        {
            Debug.Log("El numero ingresado es menor o igual a 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
