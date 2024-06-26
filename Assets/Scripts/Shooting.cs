using UnityEngine;

public class Shooting : MonoBehaviour
{
  [SerializeField] GameObject BulletPrefeb;
  [SerializeField] Transform bulletPos;
  public float BulletForce = 20f;
  public bool isOver = false;
  AudioSource FireSound;

    private void Start()
    {
        FireSound=GetComponent<AudioSource>();
    }
    private void Update()
  {
        if (!isOver)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                FireSound.Play();
                Shoot();
            }
        }
   
  }
  public void Shoot()
  {
    GameObject bullet = Instantiate(BulletPrefeb, bulletPos.position, bulletPos.rotation);
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    rb.AddForce(bulletPos.up * BulletForce,ForceMode2D.Impulse);
    Destroy(bullet, 5f);
  }
}
