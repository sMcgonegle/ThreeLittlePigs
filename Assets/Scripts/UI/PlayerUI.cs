using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    public Text ammoCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ammoCount.text = "Ammo: " + GameObject.Find("WeaponSlot").GetComponentInChildren<Weapons>().ammoAmount;
    }
}
