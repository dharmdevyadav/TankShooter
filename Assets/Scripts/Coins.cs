using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CointText;
    
    public void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
        Destroy(this.gameObject);
        PlayerMovement.CoinCollected++;
        CointText.text="Coins :" + PlayerMovement.CoinCollected.ToString();
      
    }
    
  }
    
}
