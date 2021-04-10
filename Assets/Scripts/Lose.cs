using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class Lose : MonoBehaviour
{
    public void Quit(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void ResetScene(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
