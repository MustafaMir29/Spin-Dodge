using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public GameObject EndGame;
    public GameObject Menu;
    public GameObject DuringGame;

    void Start()
    {
        EndGame.SetActive(false);
        Menu.SetActive(true);
        DuringGame.SetActive(false);

        Time.timeScale = 0f;
    }


    public void GameOpen(){
        Time.timeScale = 1f;
        EndGame.SetActive(false);
        Menu.SetActive(false);
        DuringGame.SetActive(true);
    }

    public void EndGameOpen(){
        EndGame.SetActive(true);
        Menu.SetActive(false);
        DuringGame.SetActive(false);
    }

    public void playAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



    
}
