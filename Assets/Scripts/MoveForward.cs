using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public static MoveForward instance; // 靜態變數用於追蹤實例

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; // 將當前實例設為靜態變數
            // DontDestroyOnLoad(gameObject); // 在場景切換時不銷毀該物體
        }
        else
        {
            Destroy(gameObject); // 如果已經存在實例，則銷毀重複的物體
        }
    }


    public float speed = 40.0f;
    public bool isMove = false;
    public bool isStart = false;
    private Vector3 spawnDir;
    // Update is called once per frame
    void Update()
    {
        GameObject spawnPoint = PlayerController.instance.spawnPoint;
        Vector3 targetPosition = GetMouseWorldPosition();
        Vector3 backPosition = GameObject.Find("player").transform.position;
        if (isStart) // 收到playercontroller的東西
        {
            isMove = true;
            spawnDir = (targetPosition - spawnPoint.transform.position).normalized;
        }
        if (Input.GetMouseButtonDown(1)) // 撞牆時收回
        {
            isMove = true;
            spawnDir = (backPosition - transform.position).normalized;
        }

        if(isMove){
            transform.Translate(spawnDir * speed * Time.deltaTime);
        }

    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }

    void OnCollisionEnter2D(Collision2D other){
        isStart = false;
        isMove = false;
        if (other.gameObject.CompareTag("Player")){
            Destroy(gameObject);

        }
    }
}
