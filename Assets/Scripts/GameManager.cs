using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameManager Instance;
    public  GameObject CoinText;
    public  GameObject BonusText;
    public  GameObject HealthBar;

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        PlayerMovement.CoinCollected = 0;
        Enemy.bonuspoint = 0;
        CoinText.SetActive(true);
        BonusText.SetActive(true);
        HealthBar.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
