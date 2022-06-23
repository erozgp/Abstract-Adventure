using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void juego(){
        SceneManager.LoadScene("SampleScene");
    }
    public void Instrucciones(){
        SceneManager.LoadScene("Instrucciones");
    }

    public void AcercaDe(){
        SceneManager.LoadScene("AcercaDe");
    }

    public void SalirJuego(){
        Application.Quit();
    }

    public void VolverMenu(){
        SceneManager.LoadScene("Intro");
    }
}
