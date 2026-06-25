using UnityEngine;

public class Manager : MonoBehaviour
{
	[SerializeField] GameObject enemy;
	private void Update()
	{
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
		if(targets.Length == 0)
		{
		}
	}
}
