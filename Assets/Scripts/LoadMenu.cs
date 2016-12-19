using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
	
	public GameObject menu1;
	public GameObject menu2;
	public GameObject menu3;
	public GameObject menu4;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void LoadMenu2 ()
	{	

		menu1.SetActive (false);
		menu2.SetActive (true);
		menu3.SetActive (false);
		menu4.SetActive (false);
	}

	public void LoadMenu3 ()
	{
		SceneManager.LoadScene ("CT01");
		/*
		menu1.SetActive (false);
		menu2.SetActive (false);
		menu3.SetActive (true);
		menu4.SetActive (false);
		*/
	}

	public void LoadMenu4 ()
	{
		menu1.SetActive (false);
		menu2.SetActive (false);
		menu3.SetActive (false);
		menu4.SetActive (true);
	}
}
