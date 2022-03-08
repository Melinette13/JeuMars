using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button start;
    public Button quit;

    void Start()
    {
        start.GetComponent<Button>().onClick.AddListener(StartGame);
        quit.GetComponent<Button>().onClick.AddListener(QuitGame);
    }
    public void StartGame()
    {

        SceneManager.LoadScene(1);

    }
    public void QuitGame()
    {
        Application.Quit();

    }

}

   



