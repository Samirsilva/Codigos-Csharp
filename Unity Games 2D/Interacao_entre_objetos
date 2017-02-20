// Cria uma variavel no objeto que vai disarar a interação
 
public GameObject       objetoInteracao; //Cria a variavel do objeto a ser interagido
 
void Update () {
 
 
if (Input.GetButtonDown ("Fire2")&& objetoInteracao != null) { // seleciona o input a ser chamado e verifica se esta havendo colisão ou não
           
            objetoInteracao.SendMessage("interacao", SendMessageOptions.DontRequireReceiver);
        }
}
 
void OnTriggerEnter2D(Collider2D col){//Entra em colisao com um trigger
       
        switch (col.gameObject.tag) {
       
        case "interacao":
 
            objetoInteracao = col.gameObject;
 
            break;
        }
 
}
 
void OnTriggerExit2D(Collider2D col){//Detecta a saida da colisao com um trigger
       
 
        switch (col.gameObject.tag) {
           
        case "interacao":
           
            objetoInteracao = null;
           
            break;
        }
       
}
