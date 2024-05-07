using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameManager Instance;
    Shooting ForPause;
    HealthController ClearValue;
    public GameObject PausePanel;

    public void Start()
    {
        ForPause = FindObjectOfType<Shooting>();
        ClearValue=FindObjectOfType<HealthController>();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        PlayerMovement.CoinCollected = 0;
        Enemy.bonuspoint = 0;
    }

    public void PauseGame()
    {
        ForPause.isOver = true;
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        
    }
    public void OnClickOnYes()
    {
        ForPause.isOver = false;
        Time.timeScale = 1;
        ClearValue.AllClear();
        SceneManager.LoadScene(0);
    }
    public void OnClickOnNo()
    {
        PausePanel.SetActive(false);
        ForPause.isOver = false;
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
