﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class GetUserInput : MonoBehaviour {
	//3 dropdown menus
	public Dropdown locationDD;
	public Dropdown maxCostDD;
	public Dropdown daysDD;
	string location = "";
	string maxCost = "";
	string days = "";

	public Amadeus ama;

	// Use this for initialization
	void Start () {
		ama = GameObject.Find ("AmadeusObject").GetComponent<Amadeus> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//get current option for each dropdown
	public void GetInfo(){
		location = locationDD.GetComponentInChildren<Text>().text;
		maxCost = maxCostDD.GetComponentInChildren<Text>().text;
		days = daysDD.GetComponentInChildren<Text>().text;

		Debug.Log ("button");
		ama.SetOrigin (location);
		ama.SetMaxPrice (maxCost.Substring(1));
		ama.SetDuration (days);
		//List<string> temp = new List<string> ();
		//temp.Add ("Portland");
		//temp.Add ("Portland");
		//temp.Add ("Portland");
		//temp.Add ("Portland");
		//GameObject.Find("UserInfo").GetComponent<StoreUserInfo>().setAirportList(temp);
		//List<string> temp2 = new List<string> ();
		//temp2.Add ("PDX");
		//temp2.Add ("PDX");
		//temp2.Add ("PDX");
		//temp2.Add ("PDX");
		//GameObject.Find("UserInfo").GetComponent<StoreUserInfo>().setCityList(temp2);
		//SceneManager.LoadScene ("Location Menu", LoadSceneMode.Single);
		//return;
		ama.CallQuery ();
//		StartCoroutine(ama.CallQuery ());
	}
	public string getLocation(){
		return location;
	}
	public string getMaxCost(){
		return maxCost.Substring(1);
	}
	public string getDays(){
		return days;
	}

}
