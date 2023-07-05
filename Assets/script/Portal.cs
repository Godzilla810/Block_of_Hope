using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{

    public Transform destination; // The destination portal
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            TeleportPlayer(other.transform);
        }
    }

    private void TeleportPlayer(Transform playerTransform)
    {
        playerTransform.position = destination.position;
    }
    // void OnCollisionEnter2D(Collision2D other) 
    // {
    //     if(other.gameObject.tag == "player")
    //     {
    //         Debug.Log("player");
    //         SceneManager.LoadScene("Scene2");
    //     }
    // }  
}
