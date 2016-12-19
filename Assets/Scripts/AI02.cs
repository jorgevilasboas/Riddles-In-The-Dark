using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AI02 : MonoBehaviour
{

	public Text OutputText;
	private bool keyPartClicked = false;

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

	public void ClickCama ()
	{		
		//SceneManager.LoadScene ("CTI01");
	}

	public void ClickIsqueiro ()
	{
		if (this.keyPartClicked) {
			SceneManager.LoadScene ("CT03");
		} else {
			OutputText.text = "Eu conheço esse isqueiro...";
			Invoke ("ApagaTexto", 2);
		}
	}

	public void ClickPedacoChave ()
	{
		this.keyPartClicked = true;
	}

	private void ApagaTexto ()
	{
		OutputText.text = "";
	}
}