using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public string sceneToLoad; // Le nom de la scène à charger

    public void OnMouseDown()
    {
        LoadScene();
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
