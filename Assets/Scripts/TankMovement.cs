using UnityEngine;

public class TankMovement : MonoBehaviour
{
  [SerializeField] float moveSpeed = 0.01f;
  [SerializeField] float steerSpeed = 1f; 
  public Rigidbody2D rb;
  public Transform rbBarrel;
  public Camera cam;
  Vector3 mousePos;

  private void Update()
  {
    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    var dir = new Vector2(mousePos.x - rbBarrel.position.x, mousePos.y - rbBarrel.position.y);
    rbBarrel.up = dir;
  }

  private void FixedUpdate()
  {
        float SteerAmount = Input.GetAxisRaw("Horizontal")*steerSpeed;
        float UpDown = Input.GetAxisRaw("Vertical")* moveSpeed;
        rb.transform.Rotate(0,0,-SteerAmount);
        rb.transform.Translate(0,UpDown,0);
   
  }
}
