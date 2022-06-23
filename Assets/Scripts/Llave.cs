using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    //Instancio los bloques que funcionan como puerta
    public GameObject[] puertas;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll) {
        //Se verifica si el jugador colisiona con la llave para
        //desbloquear la puerta
        if (coll.CompareTag("Player"))
        {
            //Se destruyen las puertas y la llave
            foreach (GameObject puerta in puertas)
            {
                Destroy(puerta);
            }
            Destroy(gameObject);
        }
    }
}
