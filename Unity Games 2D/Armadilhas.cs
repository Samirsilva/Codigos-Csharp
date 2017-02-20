using UnityEngine;
using System.Collections;
 
public class armadilha : MonoBehaviour {
 
    public GameObject pedra; // informa qual objeto pra ser instanciado;
    public GameObject flecha;
    public Transform  spawn;
 
    public bool       atirador;
    public float      velocidadeTiro;
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
   
    }
 
    void OnTriggerEnter2D(Collider2D col){
 
        if (col.gameObject.tag == "Player") {
 
            if(!atirador){
 
           
            GameObject tempPrefab = Instantiate (pedra) as GameObject;
            tempPrefab.transform.position = spawn.position;
            }else{
 
                GameObject tempPrefab = Instantiate (flecha) as GameObject;
                tempPrefab.transform.position = spawn.position;
                tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2 (velocidadeTiro,0));
 
            }
        }
    }
}
