//15.Existen dos reglas que identifican dos conjuntos de valores:
//-El número es de un solo dígito.
//- El número es impar.
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
//estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
//para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
//ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,
//escribiendo los resultados.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public int num1;

    bool estaEnA = true;
    bool estaEnB = true;
    bool estaEnAmbos = true;
    bool noEstaEnNinguno = true;

    string numero1;
    int digitos;
    // Start is called before the first frame update
    void Start()
    {
        numero1 = num1.ToString();

        digitos = numero1.Length;

        if (digitos == 1 && num1 % 2 == 0 )
        {
            estaEnA = true;
            estaEnB = false;
            estaEnAmbos = false;
            noEstaEnNinguno = false;

            Debug.Log("El número es solo del conjunto de un solo dígito: " + estaEnA);
            Debug.Log("El número es solo del conjunto de los numeros impares: " + estaEnB);
            Debug.Log("El número pertecene a ambos conjuntos: " + estaEnAmbos);
            Debug.Log("El número no pertence a ninguno conjunto: " + noEstaEnNinguno);

        }

        else if (digitos > 1 && num1 % 2 != 0)
        {
            estaEnA = false;
            estaEnB = true;
            estaEnAmbos = false;
            noEstaEnNinguno = false;

            Debug.Log("El número es solo del conjunto de un solo dígito: " + estaEnA);
            Debug.Log("El número es solo del conjunto de los numeros impares: " + estaEnB);
            Debug.Log("El número pertecene a ambos conjuntos: " + estaEnAmbos);
            Debug.Log("El número no pertence a ninguno conjunto: " + noEstaEnNinguno);

        }

        else if (digitos == 1 && num1 % 2 != 0)
        {
            estaEnA = false;
            estaEnB = false;
            estaEnAmbos = true;
            noEstaEnNinguno = false;

            Debug.Log("El número es solo del conjunto de un solo dígito: " + estaEnA);
            Debug.Log("El número es solo del conjunto de los numeros impares: " + estaEnB);
            Debug.Log("El número pertecene a ambos conjuntos: " + estaEnAmbos);
            Debug.Log("El número no pertence a ninguno conjunto: " + noEstaEnNinguno);
        }

        else if (digitos >= 1 && num1 % 2 == 0)
        {
            estaEnA = false;
            estaEnB = false;
            estaEnAmbos = false;
            noEstaEnNinguno = true;

            Debug.Log("El número es solo del conjunto de un solo dígito: " + estaEnA);
            Debug.Log("El número es solo del conjunto de los numeros impares: " + estaEnB);
            Debug.Log("El número pertecene a ambos conjuntos: " + estaEnAmbos);
            Debug.Log("El número no pertence a ninguno conjunto: " + noEstaEnNinguno);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
