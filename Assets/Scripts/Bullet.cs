using UnityEngine;

public class Bullet : MonoBehaviour
{
  [SerializeField] GameObject hitEffect;
    [SerializeField] GameObject EnemyHitEffect;
    public int damage;
    public static int Count;
  public void OnCollisionEnter2D(Collision2D col)
  {
        if (col.gameObject.tag == "Enemy")
        {
            Count++;
            if (Count >=2)
            {
                GameObject Enemyeffect = Instantiate(EnemyHitEffect, transform.position, Quaternion.identity);
                Destroy(Enemyeffect,0.3f);
                Count = 0;
                Destroy(gameObject);
            }
            else
            {
                GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
                Destroy(effect,0.1f);
                Destroy(gameObject);
            }
        }
        else
        {
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.7f);
            Destroy(gameObject);
        }

    }
}
