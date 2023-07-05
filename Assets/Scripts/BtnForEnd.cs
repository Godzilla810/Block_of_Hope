using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnForEnd : MonoBehaviour
{
    public GameObject canvas;

    public void ShowKeepMenu(){
        canvas.SetActive(true);
    }
    public void GameEnd(){
        Debug.Log("Game Over");
    }
}
