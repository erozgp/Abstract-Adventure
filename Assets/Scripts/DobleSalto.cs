using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DobleSalto : MonoBehaviour
{
     //Referencia al collider que posee el enemigo
    Collider2D collider;

    //instanciamos al jugador
    public PlayerMovement Player;
    // Start is called before the first frame update
    void Start()
    {
        //se obtiene el collider
        collider = GetComponent<Collider2D>();
    }
    
    void OnTriggerEnter2D(Collider2D coll) {
        //Verificamos el jugador haya tomado el doble salto para activarlo
        if (coll.gameObject.CompareTag("Player") && coll.gameObject != null)
        {
            //Se pone en true la bandera para el doble salto
            Player.doubleJump = true;
            
            //Se elimina el item de doble salto del mapa
            Destroy(gameObject);
            
        }
    }
}
