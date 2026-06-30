using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
	[SerializeField] GameObject generator;
	[SerializeField] AudioClip BGM;
	AudioSource aud;

	private void Start()
	{
		aud = GetComponent<AudioSource>();
		aud.PlayOneShot(BGM);
	}
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
