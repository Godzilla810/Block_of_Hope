using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_gate : MonoBehaviour
{
    public Transform destination; // The destination portal
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.transform);
        }
    }
    private void TeleportPlayer(Transform playerTransform)
    {
        playerTransform.position = destination.position;
    }
}
