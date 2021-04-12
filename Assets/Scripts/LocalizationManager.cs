using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalizationManager : MonoBehaviour
{
    public void Ru(){
        string language = "Ru";
        PlayerPrefs.SetString("Language", language);
    }
    public void Eng(){
        string language = "Eng";
        PlayerPrefs.SetString("Language", language);
    }
    public void Back(){
        SceneManager.LoadScene(0);
    }
}
