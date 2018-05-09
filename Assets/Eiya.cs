using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eiya : MonoBehaviour {
    
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            var auds = collision.gameObject.GetComponent<AudioSource>();
            auds.PlayOneShot(auds.clip);
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Land")
        {
            var auds = collision.gameObject.GetComponent<AudioSource>();
            auds.PlayOneShot(auds.clip);
            Spown.Score--;
        }
    }
}
