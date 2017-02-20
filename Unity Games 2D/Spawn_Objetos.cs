// Cria as variaveis na armadilha ou no objeto a ser spawnado
 
public float      intervalo; // DAR o valor do interlado EX: 2 segundos.
private float     tempoCorrido;
 
 
void Update () { // no update chama a função spawn e reseta o tempo corrido.
 
        tempoCorrido += Time.deltaTime;
        if(tempoCorrido >= intervalo){
 
            Spawn();
            tempoCorrido =0;
        }
   
}
 
void Spawn(){ // Função spawn a ser chamada.
 
        if(!atirador){
           
           
            GameObject tempPrefab = Instantiate (pedra) as GameObject;
            tempPrefab.transform.position = spawn.position;
        }else{
           
            GameObject tempPrefab = Instantiate (flecha) as GameObject;
            tempPrefab.transform.position = spawn.position;
            tempPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2 (velocidadeTiro,0));
           
        }
    }
