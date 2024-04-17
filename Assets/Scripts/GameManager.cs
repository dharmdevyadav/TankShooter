using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameManager Instance;
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

    public void QuitGame()
    {
        Application.Quit();
    }
}
