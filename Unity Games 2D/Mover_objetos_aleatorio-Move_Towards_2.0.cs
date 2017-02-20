using UnityEngine;
using System.Collections;
 
public class movePlatforma : MonoBehaviour {
 
    public  float           velocidade;
    public  GameObject      objeto; //objeto que sera movido.
    public  Transform       A;
    public  Transform       B;
    public  Transform       C;
    public  Transform       destino;
    private string          rota; // rota 0 de A para B // rota 1 de B para C // rota 2 de C pra B.
    private int             rand;
 
    // Use this for initialization
    void Start () {
 
        objeto.transform.position   =   A.position;
        rand = Random.Range (0, 100);   //
 
        if (rand < 50) {
 
            rota = "B";
            destino.position = B.position;
        } else {
       
            rota = "C";
            destino.position = C.position;
        }
 
    }
   
    // Update is called once per frame
    void Update () {
   
        float step                  =   velocidade * Time.deltaTime; // Corrige variaçoes de FPS;
        objeto.transform.position   =   Vector3.MoveTowards (objeto.transform.position,destino.position,    step);
 
        if(objeto.transform.position == destino.position){
 
 
            switch(rota){
 
            case "A":
 
                rand = Random.Range (0, 100);   //
               
                if (rand < 50) {
                   
                    rota = "B";
                    destino.position = B.position;
                } else {
 
                    rota = "C";
                    destino.position = C.position;
                }
 
            break;
 
            case "B":
 
                rand = Random.Range (0, 100);   //
               
                if (rand < 50) {
                   
                    rota = "C";
                    destino.position = C.position;
                } else {
                   
                    rota = "A";
                    destino.position = A.position;
                }
 
            break;
 
            case "C":
               
                rand = Random.Range (0, 100);   //
               
                if (rand < 50) {
                   
                    rota = "A";
                    destino.position = A.position;
                } else {
                   
                    rota = "B";
                    destino.position = B.position;
                }
               
                break;
 
           
            }
 
        }
    }
}
