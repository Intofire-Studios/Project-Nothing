using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject Lose;
    public void PauseOn(){
        Pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void PauseOff(){
        Pause.SetActive(false);
        Time.timeScale = 1;
    }
    public void Loose(){
        Lose.SetActive(true);
    }
    public void Quit(){
        SceneManager.LoadScene(0);
    }
}