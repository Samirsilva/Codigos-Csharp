using UnityEngine;
using System.Collections;
 
public class fantasma : MonoBehaviour {
 
 
    private estudo estudo;  // interage com o script estudo
 
    public float    velocidade;
 
    private bool    estaEsquerda; // true
 
    // Use this for initialization
    void Start () {
   
        estudo = FindObjectOfType (typeof(estudo)) as estudo; // inicia o script
    }
   
    // Update is called once per frame
    void Update () {
 
        if (transform.position.x < estudo.transform.position.x) {  // corrige erro de posiçao
 
            estaEsquerda = true;
       
        } else if (transform.position.x > estudo.transform.position.x) {
 
            estaEsquerda = false;
        }
 
 
        float step                  =   velocidade * Time.deltaTime; // Corrige variaçoes de FPS;
 
        if (estudo.olhandoDireita == false && estaEsquerda == false) {
       
            transform.position = Vector3.MoveTowards (transform.position, estudo.transform.position, step);
       
        } else if (estudo.olhandoDireita == true && estaEsquerda == true) {
 
            transform.position = Vector3.MoveTowards (transform.position, estudo.transform.position, step);
        }
   
    }
}
