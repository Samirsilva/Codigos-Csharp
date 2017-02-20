using UnityEngine;
using System.Collections;
 
public class estudo : MonoBehaviour {
 
    public  Animator        anim;
    public  Rigidbody2D     playerRigidibody;
    private bool            andar;
 
    private float           horizontal;
    public  float           velocidade;
    public  float           forcaPulo;
 
    public  bool            olhandoDireita;
 
    public  bool            pisandoNoChao;
    public  Transform       groundCheck;
    public  LayerMask       whatsIsGround; //permite selecionar Layers
 
    // Use this for initialization
    void Start () {
 
    }
   
    // Update is called once per frame
    void Update () {
 
        horizontal = Input.GetAxisRaw("Horizontal");
 
        pisandoNoChao = Physics2D.OverlapCircle(groundCheck.position,0.02f, whatsIsGround);
 
        if (Input.GetButtonDown ("Jump")&& pisandoNoChao == true) {
       
            playerRigidibody.AddForce(new Vector2(0, forcaPulo));
        }
 
 
        if (horizontal > 0 && olhandoDireita == false) {
 
            virarPersonagem ();
        } else if (horizontal < 0 && olhandoDireita == true) {
       
            virarPersonagem(); 
        }
 
        playerRigidibody.velocity = new Vector2 (horizontal*velocidade,playerRigidibody.velocity.y);
 
        if (horizontal != 0) {
 
            andar = true;
        } else {
       
            andar = false;
        }
   
        anim.SetBool ("andar", andar);
        anim.SetBool ("pisandoChaoAnimator",pisandoNoChao);
        anim.SetFloat ("velocidadeY",playerRigidibody.velocity.y);
 
    }
 
    void virarPersonagem(){
   
        olhandoDireita = !olhandoDireita;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
 
    }
 
}
