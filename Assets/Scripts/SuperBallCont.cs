using UnityEngine;
using UnityEngine.InputSystem;

public class SuperBallCont : MonoBehaviour
{
	[SerializeField] GameObject genarator;
	[SerializeField] GameObject manager;
	float speedx;
	float speedy;
	int boundcounter;
	bool ThrowBall;
	Vector2 startPos;
	private void Update()
	{
		if (ThrowBall == false)
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
				this.speedx = swipeLengthx / 15000.0f;
				this.speedy = swipeLengthy / 15000.0f;
				ThrowBall = true;
			}
		}
		transform.Translate(-speedx, -speedy, 0); //移動

		if (transform.position.x > 15 || transform.position.x < -15 || transform.position.y > 9 || transform.position.y < -9)
		{
			genarator.GetComponent<Generator>().ball(false);
			genarator.GetComponent<Generator>().sball(false);
			Destroy(gameObject);
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("human"))
		{

		}
		else if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("BreakWall") || collision.gameObject.CompareTag("GWall"))
		{
			speedx = speedx * -1;
			boundcounter++;
			if (boundcounter == 10)
			{
				ThrowBall = false;
				genarator.GetComponent<Generator>().ball(false);
				genarator.GetComponent<Generator>().sball(false);
				Destroy(gameObject);
			}
		}
		else if(collision.gameObject.CompareTag("yuka"))
		{
			speedy = speedy * -1;
			boundcounter++;
			if(boundcounter == 10)
			{
				ThrowBall = false;
				genarator.GetComponent<Generator>().sball(false);
				genarator.GetComponent<Generator>().ball(false);
				Destroy(gameObject);
			}
		}
		else if (collision.gameObject.CompareTag("Enemy"))
		{
			ThrowBall = false;
			Destroy(collision.gameObject);
			genarator.GetComponent<Generator>().ball(false);
			Destroy(gameObject);
		}
		else 
		{
			ThrowBall = false;
			genarator.GetComponent<Generator>().ball(false);
			Destroy(gameObject);
		}
	}
}
