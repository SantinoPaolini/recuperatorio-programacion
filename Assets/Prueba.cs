using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour

{
    public string sabor;
    public float gramos;

    // Start is called before the first frame update
    void Start()
    {
        float precio = gramos * 0.5f;
        float fru = precio * 0.9f;

        if (sabor != "fru " & sabor != "cho " & sabor != "ddl ")
        {
            Debug.Log("Lo siento, ingresar unicamente ddl, fru, o cho ");
        }
        else if (gramos < 250)
        {
            Debug.Log(" Lo siento, no podemos darte esa cantidad de helado ");
        }
        else if (gramos > 3000)
        {
            Debug.Log(" Lo siento, no podemos darte esa cantidad de helado ");
        }
        else if (sabor == "fru ")
        {
            Debug.Log("El precio es de " + fru + "pesos ");
        }
        else if (sabor == "cho " & sabor == "ddl")
        {
            Debug.Log(" El precio es de " + precio + "pesos");
        }
        
    


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
