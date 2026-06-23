using UnityEngine;

public class EnemyController : MonoBehaviour
{
	float moveSpeed = 0.005f;
	private void Update()
	{
		transform.Translate(moveSpeed, 0, 0);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Stone") || collision.gameObject.CompareTag("Sball"))
		{
			Destroy(gameObject);
		}
		moveSpeed = moveSpeed * -1;
	}
}
