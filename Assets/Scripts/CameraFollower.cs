using UnityEngine;

public class CameraFollower : MonoBehaviour
{
  [SerializeField] Transform Player;
  public Vector3 Offset;

  private void Update()
  {
    transform.position = Player.position + Offset;
  }
}
