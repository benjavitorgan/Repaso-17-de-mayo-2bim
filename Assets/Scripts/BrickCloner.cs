using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float xOffset;
    public int cantCubos;
    public int counter = 0;
    public Text UserOffset;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(brickPrefab); //Instanciar el prefab
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloneBrick () //Creo funcion para que se ejecute al apretar el boton
    {
        if (counter == 0)
        {
            xOffset = float.Parse(UserOffset.text); /*Parseo el UserOffset para que lo tome como float*/
        }
            if (counter < 5)
            {

                GameObject clon; //Creo un GO
                clon = Instantiate(brickPrefab); //El instantiate devuelve un GO y se lo asigno a clon que tmb es un GO
                clon.transform.position = new Vector3(xOffset, 0, 0); //Creo variable float para que la posicion vaya cambiando cada que apreto el boton. La variable aumenta al ejecutar la funcion. Asigno el float a la posicion X del vector 3
                                                                      //xOffset += 1.1f; //Doy el valor al float segun los metros que quiero que cambie el clon 
                counter++; //Creo un contador que me diga cuantos cubos se crearon y la sumo cada que se ejecute el boton
            }
        
    }
}
