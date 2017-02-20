using UnityEngine;
using System.Collections;
 
public class movePlatforma : MonoBehaviour {
 
    public  float           velocidade;
    public  GameObject      objeto; //objeto que sera movido.
    public  Transform       A;
    public  Transform       B;
    public  Transform       C;
    public  Transform       destino;
    private int             rota; // rota 0 de A para B // rota 1 de B para C // rota 2 de C pra B.
 
    // Use this for initialization
    void Start () {
        rota = 0;
        objeto.transform.position   =   A.position;
        destino.position            =   B.position;
    }
   
    // Update is called once per frame
    void Update () {
   
        float step                  =   velocidade * Time.deltaTime; // Corrige variaçoes de FPS;
        objeto.transform.position   =   Vector3.MoveTowards (objeto.transform.position,destino.position,    step);
 
        if(objeto.transform.position == destino.position){
 
            if(rota ==0){ //A para B
 
                destino.position = C.position;
                rota =1;
            }
            else if(rota ==1){ //B para C
 
                rota =2;
                destino.position = A.position;
 
            }
            else if(rota ==2){ //B para C
               
                rota =0;
                destino.position = B.position;
               
            }
 
        }
    }
}
