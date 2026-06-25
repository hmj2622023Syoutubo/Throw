using UnityEngine;

public class BossController : MonoBehaviour
{
	[SerializeField] GameObject wall;
	int hitcounter;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		hitcounter++;
		if(hitcounter == 1)
		{
			GameObject item;
			GameObject[] targets = GameObject.FindGameObjectsWithTag("Wall");
			foreach (GameObject target in targets)
			{
				Destroy(target);
			}
			item = Instantiate(wall);

		}
		else if(hitcounter == 2)
		{

		}
		else if (hitcounter == 3)
		{
			Debug.Log("seikou");
			Destroy(gameObject);
		}
	}
}
