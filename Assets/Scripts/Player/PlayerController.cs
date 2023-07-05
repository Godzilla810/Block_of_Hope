using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;
    void Awake() {
        if (instance != null){
            Debug.LogError("More than one PlayerController in scene!");
            return;
        }
        instance = this;
    }

    public float speed = 40.0f;
    public bool isMove = false;
    public GameObject spawnPoint;
    public GameObject MBPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 當左鍵點擊時
        {
            Instantiate(MBPrefab, spawnPoint.transform.position, transform.rotation);
            MoveForward.instance.isStart = true;
        }
    }
}
