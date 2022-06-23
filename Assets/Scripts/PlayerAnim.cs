using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator animator;
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        //Obteniendo los compontes dentro del juego para su uso
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Cambio de estado para la caminata gracias a la variable que se actualiza en PlayerMovement
        animator.SetBool("Walking",playerMovement.moving);
    }

    public void TriggerJump(){
        //Seteo del trigger para el salto
        animator.SetTrigger("Jump");
    }
}
