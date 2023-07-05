using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f ;

    [SerializeField] int Hp;

    GameObject monsters;
    GameObject door;
    GameObject detection;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");

        Hp = 100;
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "door")
        {
            Debug.Log("door");
            door = other.gameObject;
        }
        else if(other.gameObject.tag == "detection")
        {
            Debug.Log("hit");
            ChangeScene("Scene2");
            // detection.GetComponent<BoxCollider2D>().enabled = false;
        }
        //else if(other.gameObject.tag == "detection")
        //{
            //Debug.Log("closedoor");
            //door.GetComponent<BoxCollider2D>().enabled = true;
        //}

        else if(other.gameObject.tag == "bat")
        {
            Debug.Log("bat");
            monsters = other.gameObject;
        }
    }  

    void ModifyHp(int num)
    {
        Hp += num;
        if(Hp>100)
        {
            Hp = 100;
        }
        else if(Hp<0)
        {
            Hp = 0;
        }

    }

}
