using UnityEngine;

public class MoveWall : MonoBehaviour
{
	float moveSpeed = 0.01f;
	private void Update()
	{
		transform.Translate(0, moveSpeed, 0);
		if (transform.position.y > 3.5 ||  transform.position.y < -3)
		{
			moveSpeed *= -1;
		}
	}

	
}
