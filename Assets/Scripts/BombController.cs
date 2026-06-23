using UnityEngine;
using UnityEngine.InputSystem;

public class BombController : MonoBehaviour
{
	[SerializeField] GameObject genarator;
	[SerializeField] GameObject Breakwall;
	float speedx;
	float speedy;
	Vector2 startPos;
	private void Update()
	{
		//スワイプの長さを求める
		if (Mouse.current.leftButton.wasPressedThisFrame) //マウスがクリックされたら
		{
			//マウスをクリックした座標
			this.startPos = Mouse.current.position.value;
		}
		else if (Mouse.current.leftButton.wasReleasedThisFrame)
		{
			//マウスを離した座標
			Vector2 endPos = Mouse.current.position.value;
			float swipeLengthx = endPos.x - this.startPos.x;
			float swipeLengthy = endPos.y - this.startPos.y;

			//スワイプの長さを初速度に変換する
			this.speedx = swipeLengthx / 5000.0f;
			this.speedy = swipeLengthy / 5000.0f;
		}
		transform.Translate(-speedx, -speedy, 0); //移動
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("BreakWall"))
		{
			genarator.GetComponent<Generator>().ball(false);
			Destroy(collision.gameObject);
			Destroy(gameObject);
		}
		else if (collision.gameObject.CompareTag("human"))
		{

		}
		else
		{
			genarator.GetComponent<Generator>().bomb(false);
			genarator.GetComponent<Generator>().ball(false);
			Destroy(gameObject);
		}

	}

}
