using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
	[SerializeField] AudioClip BGM;
	AudioSource aud;
	private void Start()
	{
		aud = GetComponent<AudioSource>();
		aud.PlayOneShot(BGM);
	}

	private void Update()
	{
		if (Mouse.current.leftButton.isPressed)
		{
			SceneManager.LoadScene("GameScene");
		}
	}
}
