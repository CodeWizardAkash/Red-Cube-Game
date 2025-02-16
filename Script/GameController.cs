using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class GameController : MonoBehaviour
{   
    public static GameController instance;
    public GameObject GameOverPanel;
    public GameObject TapToStart;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {   score_script.instance.ScoreObject.SetActive(false);
        GameOverPanel.SetActive(false);
        PauseGame();
        TapToStart.SetActive(true);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            StartGame();
        }
    }
    public void GameOver()
    {   
        GameOverPanel.SetActive(true);
        PauseGame();
        // Debug.Log("Game Over");
    }
    public void Restart()
    {   
        // StartGame();
        SceneManager.LoadScene("GameScene");        
    }
    public void QuitGame(){
        Application.Quit();
    }
    public void StartGame()
    {   
        score_script.instance.ScoreObject.SetActive(true);
        TapToStart.SetActive(false);
        Time.timeScale = 1f;
    }
    public void PauseGame()
    {   score_script.instance.ScoreObject.SetActive(false);
        Time.timeScale = 0f;
    }
}
