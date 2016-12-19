using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CT01 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Invoke ("LoadAI01", 5);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	private void LoadAI01 ()
	{
		SceneManager.LoadScene ("AI01");
	}
}
