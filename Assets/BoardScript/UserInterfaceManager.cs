using UnityEngine;
using System.Collections;

public class UserInterfaceManager : MonoBehaviour
{
	//child UI
//	public GameObject inventory;
//	public GameObject skillUI;
//	public GameObject status;
	public GameObject enterDungeon;

	//initialize this script
	void Start( )
	{
//		inventory = GameObject.Find( "Inventory" );
//		skillUI = GameObject.Find( "SkillUI" );
//		status = GameObject.Find( "Status" );
		enterDungeon = GameObject.Find( "EnterDungeon" );
		Debug.Log (enterDungeon);
	}
	public bool OnEnterDungeon
	{
		get 
		{
			return enterDungeon.activeInHierarchy;
		}
	}

	// Update is called once per frame
//	void Update( )
//	{
//		Debug.Log( inventory );
//	}
//
//	// control UI 
//	//inventory
//	public void ControlInventory(bool state)
//	{
//		inventory.SetActive( state );
//	}
//	//skill ui
//	public void ControlSkillUI(bool state)
//	{
//		skillUI.SetActive( state );
//	}
//	//status ui
//	public void ControlStatus(bool state)
//	{
//		status.SetActive( state );
//	}
//	// enter dungeon
	public void ControlEnterDungeon(bool state)
	{
		enterDungeon.SetActive( state );
	}
}