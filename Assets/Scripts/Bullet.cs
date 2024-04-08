using UnityEngine;

public class Bullet : MonoBehaviour
{
  [SerializeField] GameObject hitEffect;
  public void OnCollisionEnter2D(Collision2D col)
  {
    GameObject effect=Instantiate(hitEffect,transform.position, Quaternion.identity);
    Destroy(effect, 1f);
    Destroy(gameObject);
  }
}
