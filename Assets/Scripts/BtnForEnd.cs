using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnForEnd : MonoBehaviour
{
    //實例化
    public static BtnForEnd instance;
    void Awake() {
        if (instance != null){
            Debug.LogError("More than one BtnManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject canvas;
    public bool isPause = false;

    public void Pause(){
        isPause = true;
        ShowMenu();
    }
    public void ShowMenu(){
        canvas.SetActive(true);
    }
    public void GameEnd(){
        SceneManager.LoadScene(04);
    }

}
