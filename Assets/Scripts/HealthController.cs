using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject CoinObj;
    [SerializeField] GameObject BonusObj;
    [SerializeField] GameObject HealthBar;
    Shooting ToCheckOverGame;
    BonusHandler EnemyBonus;
    ScoreManager score;

    private void Start()
    {
        ToCheckOverGame = FindAnyObjectByType<Shooting>();
        score = FindObjectOfType<ScoreManager>();
        healthSlider.value =1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            healthSlider.value -= 0.2f;
            if(healthSlider.value <= 0)
            {
                gameOverPanel.SetActive(true);
                Time.timeScale = 0;
                score.coinText.text = "You Have Finally Collected "+Coins.FinalScore.ToString()+" Coins!";
                score.BonusText.text = "You Have Won " + Enemy.bonusint.ToString()+ " Bonus Points!";
                ToCheckOverGame.isOver = true;
                PlayerMovement.CoinCollected = 0;
                Enemy.bonuspoint = 0;
            }
        }

       
    }
}
