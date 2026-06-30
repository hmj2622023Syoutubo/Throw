using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
	[SerializeField] GameObject generator;
	private void Update()
	{
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
		if(targets.Length == 0)
		{
			generator.GetComponent<Generator>().sball(false);
			generator.GetComponent<Generator>().bomb(false);
			SceneManager.LoadScene("BossScene");
		}
	}
}
