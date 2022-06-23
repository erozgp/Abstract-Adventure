using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerOnTrigger : MonoBehaviour
{

    //Variables para manejar el intervvalo de daño
    private float tiempoAtaque = 1.0f;
    private float siguienteAtaque;
    //Referencia al collider que posee el enemigo
    Collider2D collider;
    
    //Jugador
    public Vidas VidasJugador;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
    }
    
    void OnTriggerEnter2D(Collider2D coll) {
        //Verificamos qué objeto tocó el enemigo y el tiempo pora el daño
        if (coll.gameObject.CompareTag("Player") && Time.time > siguienteAtaque)
        {
            //Se asigna el tiempo para el siguiente ataque
            siguienteAtaque = Time.time + tiempoAtaque;
            //Si se sufre daño entonces se aplica daño
            VidasJugador.DañoDeVida(1);
            
            //SceneManager.LoadScene(Respawn);
            //Destroy(coll.gameObject);
            
        }
    }
}
