using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CT02 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Invoke ("LoadAI02", 5);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	private void LoadAI02 ()
	{
		SceneManager.LoadScene ("AI02");
	}
}
