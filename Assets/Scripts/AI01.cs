using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AI01 : MonoBehaviour
{

	public Text OutputText;

	// Use this for initialization
	void Start ()
	{		
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void ClickFundo ()
	{
		OutputText.text = "Não parece haver nada de útil aqui.";
		Invoke ("ApagaTexto", 2);
	}

	public void ClickPorta ()
	{		
		SceneManager.LoadScene ("CT02");
	}

	private void ApagaTexto ()
	{
		OutputText.text = "";
	}
}
