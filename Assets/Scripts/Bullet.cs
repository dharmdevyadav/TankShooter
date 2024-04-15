using UnityEngine;

public class Bullet : MonoBehaviour
{
  [SerializeField] GameObject hitEffect;
    [SerializeField] GameObject EnemyHitEffect;
    public int damage;
  public void OnCollisionEnter2D(Collision2D col)
  {
        if (col.gameObject.tag == "Enemy")
        {
            GameObject Enemyeffect = Instantiate(EnemyHitEffect, transform.position, Quaternion.identity);
            Destroy(Enemyeffect, 1f);
            Destroy(gameObject);
        }
        else
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            Destroy(gameObject);
        }
    
  }
}
