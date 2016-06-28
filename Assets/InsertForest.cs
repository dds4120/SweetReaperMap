using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InsertForest : MonoBehaviour {
	

	public void OnGUI()
	{
		Debug.Log ("Change fayeTest");
		SceneManager.LoadScene ("FayeTest");
	}
	public void ExitGUI()
	{
		Debug.Log ("dungeon clear");
		Application.Quit ();

	}
}
