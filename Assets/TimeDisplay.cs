using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = string.Format("Time: {0}", Time.time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
