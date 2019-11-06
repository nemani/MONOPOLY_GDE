using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLocationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		self.PlayerNumber = 0;
        Debug.log("init!");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.log("update!");
	}
	
	public int PlayerNumber;
	public GameObject PlaceHolder;

}
