using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class HealthController : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject CoinObj;
    [SerializeField] GameObject BonusObj;
    [SerializeField] GameObject HealthBar;
    Shooting ToCheckOverGame;
    Coins coinScript;
    BonusHandler EnemyBonus;

    private void Start()
    {
        ToCheckOverGame = FindAnyObjectByType<Shooting>();
        coinScript = FindAnyObjectByType<Coins>();
        EnemyBonus = FindAnyObjectByType<BonusHandler>();
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
                Debug.Log("After Visible Page Score" + coinScript.CoinText.text);
                Debug.Log("After Visible Page Score" + EnemyBonus.BonusPointText.text);
                ToCheckOverGame.isOver = true;
                CoinObj.SetActive(false);
                BonusObj.SetActive(false);
                HealthBar.SetActive(false);
                PlayerMovement.CoinCollected = 0;
                Enemy.bonuspoint = 0;
            }
        }

       
    }
}
