using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //The Players object(what the camera follows right now)
    private GameObject player;

    //Gets called once immediately after it is spawned in
	void Awake () {
        //Grab the player object by looking for an object with that tag
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
    //Late update is called every frame, after Update is called
    //Using LateUpdate rather than Update makes sure that
    //the camera follow doesn't bug out or get weird
	void LateUpdate () {
        //Make the camera follow the player
        //Only the x and y positions though, otherwise we wouldn't see anything
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
	}
}
