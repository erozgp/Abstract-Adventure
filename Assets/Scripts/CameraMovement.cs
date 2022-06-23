using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Hacemos uso de nueestro jugador
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        //En cada actualización del jugador asignamos las nuevas
        //posiciones a la cámara 
        Vector3 position = transform.position;
        position.x = Player.transform.position.x;
        position.y = Player.transform.position.y;
        transform.position = position;
    }
}
