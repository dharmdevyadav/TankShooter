using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
  [SerializeField] float moveSpeed = 5f;
  public Rigidbody2D rb;
  public Transform rbBarrel;

  //float Offset = 90f;
  public Camera cam;
  Vector2 movement;
  Vector3 mousePos;

  private void Update()
  {
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    var dir = new Vector2(mousePos.x - rbBarrel.position.x, mousePos.y - rbBarrel.position.y);
    rbBarrel.up = dir;
  }

  private void FixedUpdate()
  {
    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


    //Vector2 LookAt = mousePos - rbBarrel.position;

    //float angle = Mathf.Atan2(LookAt.y, LookAt.x) * Mathf.Rad2Deg - Offset;
    
  }
}
