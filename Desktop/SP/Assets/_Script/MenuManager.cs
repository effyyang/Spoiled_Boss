using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour {
	//switch panel
	public GameObject StartPanel;
	public GameObject Mainmenu;
	public GameObject Choose;
	public GameObject UserInfo;
	public GameObject BossInfo;
	//private GameObject myobj;
	// Use this for initialization
	private float myTicktime = 3.0f; 
	int bossidx;
	void Awake(){
		switch_panel ("default");


	}
	
	// Update is called once per frame
	void Update () {
		myTick ();
		readData ();
		Debug.Log (bossidx);
	}
	public void switch_panel(string menu_name)
	{
		StartPanel.SetActive (true);
		
		Choose.SetActive (false);
		UserInfo.SetActive (false);
		BossInfo.SetActive (false);
		switch (menu_name) {
		case "MainMenu":
			Mainmenu.SetActive (true);
			Choose.SetActive (false);
			UserInfo.SetActive (false);
			BossInfo.SetActive (false);
			break;
		case "UserInfo":
			UserInfo.SetActive (true);
			Choose.SetActive (false);
			Mainmenu.SetActive (false);
			BossInfo.SetActive (false);
			break;
		/*case "BossInfo":///wont use this penal
			BossInfo.SetActive (true);
			Choose.SetActive (false);
			UserInfo.SetActive (false);
			Mainmenu.SetActive (false);
			break;*/
		case "Choose":
			Choose.SetActive (true);
			Mainmenu.SetActive (false);
			UserInfo.SetActive (false);
			BossInfo.SetActive (false);
			break;




		}

	}
	void myTick()
	{
		myTicktime -= Time.deltaTime;
		if (myTicktime < 0) {
			StartPanel.SetActive (false);
			Mainmenu.SetActive (true);
		}

	}
	public void load(){

		Debug.Log ("load scene successfull");
		SceneManager.LoadScene ("Main_scene");
	}
	public void quit(){
		//leave game
		Debug.Log("exit scessfull");
		Application.Quit ();
	}
	void readData(){
		InputField name = GameObject.Find ("Name").GetComponent<InputField>();
		if (name.text != null) {//store data in kernal
			Debug.Log (name.text);
		}
		
		InputField Birth = GameObject.Find ("Birthday").GetComponent<InputField>();
		if (Birth.text != null) {
		}

	}
public void BossIdx(int idx){

	bossidx = idx;
}
}
