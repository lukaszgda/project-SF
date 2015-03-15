using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public void LadujScene(int poziom)
	{
		Application.LoadLevel (poziom);
	}

	public void Wyjdz()
	{
		Application.Quit ();
	}
}
