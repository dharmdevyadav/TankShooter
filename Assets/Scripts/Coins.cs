using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player"))
    {
      PlayerMovement.CoinCollected++;
      Debug.Log("The number of coins collected are :" + PlayerMovement.CoinCollected);
      Destroy(gameObject);
    }
  }
}
