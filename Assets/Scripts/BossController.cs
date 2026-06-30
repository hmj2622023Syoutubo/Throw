using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossController : MonoBehaviour
{
	[SerializeField] GameObject longwall;
	[SerializeField] GameObject wall;
	[SerializeField] GameObject Movewall;
	int hitcounter;
	float X;
	float Y;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject item;
		hitcounter++;
		if(hitcounter == 1)
		{
			GameObject[] targets = GameObject.FindGameObjectsWithTag("Wall");
			foreach (GameObject target in targets)
			{
				Destroy(target);
			}
			item = Instantiate(longwall);
			X = 5f;
			Y = -1.0f;
			item.transform.position = new Vector2((float)X, (float)Y);
			item = Instantiate(wall);
			X = 5f;
			Y = 4.5f;
			item.transform.position = new Vector2((float)X, (float)Y);
		}
		else if(hitcounter == 2)
		{
			GameObject[] targets = GameObject.FindGameObjectsWithTag("Wall");
			foreach (GameObject target in targets)
			{
				Destroy(target);
			}
			item = Instantiate(Movewall);
			X = 2.4f; 
			Y = 3.0f;
			item.transform.position = new Vector2((float)X, (float)Y);
			X = 3.5f;
			Y = -2.0f;
			item.transform.position = new Vector2((float)X, (float)Y);
		}
		else if (hitcounter == 3)
		{
			Destroy(gameObject);
			SceneManager.LoadScene("EndScene");
		}
	}
}
