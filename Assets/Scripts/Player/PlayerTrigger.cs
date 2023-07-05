using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private Animator animator;
    public LayerMask interactableLayer;
    // public GameObject MB;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p")){
            Debug.Log("p");
            Interact();
        }
        // if (Input.GetKeyDown(KeyCode.Space)){
        //     //Launch a projectile from the player
        //     Instantiate(MB, transform.position, transform.rotation);
        //     //Instantiate:create copy;(object,position,rotation)
        // }
    }
    void Interact(){
        Vector3 facingDir = new Vector3(animator.GetFloat("moveX"), animator.GetFloat("moveY"));
        Vector3 interactPos = transform.position + facingDir;

        Collider2D collider = Physics2D.OverlapCircle(interactPos, 0.2f, interactableLayer);
        if (collider != null){
            Debug.Log("ok");
            collider.gameObject.GetComponent<DialogTrigger>().TriggerDialog();
        }
    }
}
