        void OnCollisionEnter2D(Collision2D nomeParametro){// entra em colisao com um colisor
 
                print ("Entru em colisao com um colidor");
 
        }
 
        void OnTriggerEnter2D(Collider2D nomeParametro){//Entra em colisao com um trigger
 
                print ("Entra em colisao com um trigger");
        }
 
        void OnCollisionExit2D(){//Detecta a saida da colisao
 
                print ("Detectou a saida da colisao");
        }
 
        void OnTriggerExit2D(){//Detecta a saida da colisao com um trigger
 
                print ("Detecta a saida da colisao com um trigger");
        }
 
        void OnCollisionStay2D(){//Detecta se eu anda estou colidindo.
 
                print("Ainda esta em colisao com um colisor");
        }
 
        void OnTriggerStay2D(){//Detecta se eu anda estou colidindo com um trigger.
               
                print("Ainda esta em colisao com um trigger");
        }
