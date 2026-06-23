using UnityEngine;
using UnityEngine.InputSystem;

public class Generator : MonoBehaviour
{
	[SerializeField] GameObject Stone;
	[SerializeField] GameObject Bomb;
	[SerializeField] GameObject Sball;
	static bool BallCount;
	static bool StoneCount;
	static bool BombCount;
	static bool SuperBallCount;
	public void ball(bool ballcount)
	{
		BallCount = ballcount;
	}
	public void stone(bool stonecount)
	{
		StoneCount = stonecount;
	}
	public void bomb(bool bombcount)
	{
		BombCount = bombcount;
	}
	public void sball(bool sballcount)
	{
		SuperBallCount = sballcount;
	}

	private void Update()
	{
		GameObject item;
		if (BallCount == false)
		{
			if (Keyboard.current.aKey.isPressed && StoneCount == false)
			{
				StoneCount = true;
				BallCount = true;
				item = Instantiate(Stone);
				item.transform.position = new Vector2(-9.5f, -2);
			}
			if (Keyboard.current.sKey.isPressed && BombCount == false)
			{
				BombCount = true;
				BallCount = true;
				item = Instantiate(Bomb);
				item.transform.position = new Vector2(-9.5f, -2);
			}
			if(Keyboard.current.dKey.isPressed && SuperBallCount == false)
			{
				SuperBallCount = true;
				BallCount=true;
				item = Instantiate(Sball);
				item.transform.position = new Vector2(-9.5f, -2);
			}
		}
	}

}
