using UnityEngine;
using System.Collections;
 
public class vidaObjeto : MonoBehaviour {
 
    // Use this for initialization
    void Start () {
        Destroy (this.gameObject, 2f); // Destroi depois e 2 segundos, ate mesmo fora da tela
    }
   
    // Update is called once per frame
    void Update () {
   
    }
 
    void OnCollisionEnter2D(){
 
        Destroy (this.gameObject); // Destroi apos colidir com algum objeto
    }
 
    void OnBecameInvisible(){// essa funçao e chamada quando o objeto sair do campo de visao da camera.
 
        Destroy (this.gameObject);
    }
}
