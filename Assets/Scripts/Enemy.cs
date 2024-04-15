using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Enemy Instance;
    BonusHandler EnemyBonus;
    public float Speed;
    private Transform Player;
    public int Health;
    public static int bonuspoint;

    void Start()
    {
        Player=FindObjectOfType<TankMovement>().transform;
        EnemyBonus = FindAnyObjectByType<BonusHandler>();
    }
    void Update()
    {
        transform.position =Vector2.MoveTowards(transform.position, Player.position, Speed * Time.deltaTime);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            TakeDamage(other.gameObject.GetComponent<Bullet>().damage);
            bonuspoint += 10;
            EnemyBonus.BonusPointText.text = "BONUS:" + bonuspoint.ToString();
        }
    }
    void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        if(Health <= 0)
        { 
            Destroy(gameObject);
        }
    }
}