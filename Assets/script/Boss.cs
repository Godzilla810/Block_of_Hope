using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    private Animator animator;
    private int dmgCount;
    private int dieCount;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
        dmgCount=0;
        dieCount=0;
    }

    private void Update()
    {
        // Check for player input to switch between animator states
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Trigger the "Jump" animation state
            animator.SetTrigger("Talk");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetTrigger("Dmg");
        }
        else if (Input.GetKeyDown(KeyCode.O)||dmgCount==5)
        {
            animator.SetTrigger("Die");
            dmgCount=0;
            dieCount++;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Idle");
        }
        if(dieCount==4){
            StartCoroutine(DestroyEnemyWithDelay());
        }
    } 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("mb"))
        {
            animator.SetTrigger("Dmg");
            dmgCount++;
        }
    }
    private System.Collections.IEnumerator DestroyEnemyWithDelay()
    {
        yield return new WaitForSeconds(0.5f);

        Destroy(gameObject);
        SceneManager.LoadScene("level1");
    }
}

