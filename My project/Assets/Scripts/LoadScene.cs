using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string newScene;
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(InputHandling);
    }
    public void InputHandling() 
    {
        SceneManager.LoadScene(newScene);
    
    }
}
