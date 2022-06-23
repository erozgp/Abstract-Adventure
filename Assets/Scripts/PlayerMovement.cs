using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    //Variable pública para la velocidad del movimiento
    public float movementSpeed;
    //Variable pública para la fuerza de salto
    public float jumpForce;
    //Variable pública para la el estado de movimiento
    public bool moving;

    //Variable para verificar si el Player está saltando y si tiene salto doble habilitado
    public bool Grounded;
    public bool doubleJump;
    private int cantSaltos = 2;
    Rigidbody2D rb;

    SpriteRenderer spriteRenderer;

    //Instancia para la animación del Player
    PlayerAnim playerAnim;

    //Instanccia para el sonido del salto
    private AudioSource sonidoSalto;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializo las variables para el manejo de los saltos
        Grounded = true;
        doubleJump = false;
        //Obteniendo los compontes dentro del juego para su uso
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerAnim = GetComponent<PlayerAnim>();
        sonidoSalto = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Activación del caminar mediante un boolean
        moving = Input.GetAxisRaw("Horizontal") != 0;

        //Cambio de dirección
        spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        
        //Identificación y activación del salto o doble salto mediante la tecla de espacio
        if(Input.GetKeyDown(KeyCode.Space) && Grounded && doubleJump == false){
            sonidoSalto.Play();
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnim.TriggerJump();
            Grounded = false;            
        }
        if(Input.GetKeyDown(KeyCode.Space) && Grounded && doubleJump && cantSaltos > 0){
            sonidoSalto.Play();
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            playerAnim.TriggerJump();
            if (cantSaltos == 1)
            {
                Grounded = false;   
            }
            cantSaltos--;
            
        }
    }

    private void FixedUpdate() {
        //Caminata del personje
        Vector2 newVelocity;
        newVelocity.x = Input.GetAxisRaw("Horizontal") * movementSpeed;
        newVelocity.y = rb.velocity.y;

        rb.velocity = newVelocity;
    }

    private void OnCollisionEnter2D(Collision2D Coll){
        
        if(Coll.gameObject.name == "Deadline"){
            //Verificación de caída y reinicio del juego
            SceneManager.LoadScene("JuegoTerminado");
            //Debug.Log(Coll.gameObject.name);
            
        }else if(Coll.gameObject.name == "Escenario" && Grounded == false){
            //Verificación para solo un salto
            Grounded = true; 
            //verifiación y seteo para nuevos dos saltos solo si se tomó el item
            if (doubleJump)
            {
                cantSaltos = 2;
            }
        }else if(Coll.gameObject.name == "Nivel2"){
            //Verificación de caída y reinicio del juego
            SceneManager.LoadScene("Nivel2");
            //Debug.Log(Coll.gameObject.name);
            
        }else if(Coll.gameObject.name == "Nivel3"){
            //Verificación de caída y reinicio del juego
            SceneManager.LoadScene("Nivel3");
            //Debug.Log(Coll.gameObject.name);
            
        }else if(Coll.gameObject.name == "FinalCorona"){
            //Verificación de caída y reinicio del juego
            SceneManager.LoadScene("Fin");
            //Debug.Log(Coll.gameObject.name);
            
        }
        
    }
}
