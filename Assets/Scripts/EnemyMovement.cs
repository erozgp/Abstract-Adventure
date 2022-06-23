using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //Trasform de modo público para saber la ubicación del jugador
    public Transform target;
    //Variable para modificar la velocidad del movimiento
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
    }
}
