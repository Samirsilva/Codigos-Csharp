//Cria as variaveis.
 
public GameObject       prefab;
public Transform        arma;
public float            forcaTiro;
 
 
void Start () {  //trata um erro de virar o personagem
 
        if (!olhandoDireita) {
       
            forcaTiro *= -1;
        }
 
    }
 
void Update () {
 
    if (Input.GetButtonDown ("Fire1")) { // Chama a condição pelo input.
       
            atirar();
    }
 
}
 
void virarPersonagem(){
   
        forcaTiro *= -1; // passa a atirar para todos os lados.
       
 
}
 
void atirar(){ //função atirar
 
        GameObject tempPrefab = Instantiate (prefab) as GameObject; // instancia o prefabricado
        tempPrefab.transform.position = arma.position; // diz a posição que vai aparecer
        tempPrefab.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (forcaTiro, 0)); // adciona uma força para o tiro.
}
