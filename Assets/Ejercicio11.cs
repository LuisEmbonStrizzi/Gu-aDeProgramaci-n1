//11.Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public string FechaDeCompra;
    public string NombreDelComprador;
    public string NombreDelProducto;
    public int Cantidad;
    public int Precio;

    int Total;
    // Start is called before the first frame update
    void Start()
    {
        Total = Precio * Cantidad;

        Debug.Log(" Fecha de compra: " + FechaDeCompra);
        Debug.Log(" Nombre del comprador: " + NombreDelComprador);
        Debug.Log(" Producto solicitado: " + NombreDelProducto);
        Debug.Log(" Cantidad solicitada: " + Cantidad);
        Debug.Log(" Precio unitario: $" + Precio); 
        Debug.Log(" Total a pagar: $" + Total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
