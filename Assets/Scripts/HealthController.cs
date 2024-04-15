using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    private void Start()
    {
        healthSlider.value =1;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            healthSlider.value -= 0.2f;
            if(healthSlider.value <= 0)
            {
                SceneManager.LoadScene(0);
                PlayerMovement.CoinCollected = 0;
                Enemy.bonuspoint = 0;
            }
        }
    }
}
