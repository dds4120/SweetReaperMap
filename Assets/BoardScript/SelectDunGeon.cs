using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SelectDungeon : MonoBehaviour {

	public Image dungeonForest;
	public InsertForest DungeonInsert;
	// Use this for initialization
	void Start ()
	{
		dungeonForest = transform.Find("Forest").GetComponent<Image> ();		

	}

//	void OnMouseEnter()
//	{
//		Debug.Log ("Ente");
//
//	}
//	void OnMouseExit()
//	{
//		Debug.Log ("exit");
//	}
//	void OnMouseDown()
//	{
//		Debug.Log ("inDun");
//		//in dungeon
//	}
//

	public void FirstAreaDungeonSelect(string name)
	{
		switch (name) 
		{
		case "Forest":
			Debug.Log ("inDun");
			SceneManager.LoadScene ("FayeTest");
			break;
		}

	}


}
