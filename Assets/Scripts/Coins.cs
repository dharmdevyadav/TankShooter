using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public static int currentscore;
    public static int FinalScore;

    private void Start()
    {
        PlayerPrefs.SetString("currentscore", CoinText.text);
    }
    public void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
        Destroy(this.gameObject);
        PlayerMovement.CoinCollected++;
        currentscore =PlayerMovement.CoinCollected;
        CoinText.text="Coins :" + currentscore.ToString();
        PlayerPrefs.SetString("currentscore", currentscore.ToString());
        FinalScore = currentscore;
        }
    
  }
    
}
