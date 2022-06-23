using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Vidas : MonoBehaviour
{
    //Objetos en pantalla a mostrar la vida
    public GameObject[] corazones;
    //Cantidad de vida
    private int vidas = 3;
    //Variable para verificar el estado del personaje
    private bool dead;

    

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(dead){
            //Carga de pantalla prinipal
            SceneManager.LoadScene("JuegoTerminado");
            Debug.Log("MORISTEEEEEEEEEEE");
        }
    }

    public void DañoDeVida(int d){
        //Se asume el daño, se resta vida y se verifica el estado
        if (vidas >= 1)
        {
            
            vidas-=d;
            Destroy(corazones[vidas].gameObject);
            if (vidas < 1)
            {
                dead = true;
            }
        }
        
    }
}
