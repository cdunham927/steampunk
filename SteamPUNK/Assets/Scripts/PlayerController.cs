using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject meleeChild;
    //Variables for the players input, the players speed
    //the rigidbody that moves the player and the 
    //spriterenderer that renders him
    private Vector2 input;
    //private Vector2 contInput;
    public float moveSpd;
    private Rigidbody2D bod;
    private SpriteRenderer rend;

    //Gets called once immediately after it is spawned in
    void Awake () {
        //Get the components on the player object
        bod = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
	}
	
	void Update ()
    {
        //Keep track of the arrow keys and wasd so we can move the player accordingly
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //commented out the controller input, its there if we want to add controller support in later
        //contInput = new Vector2(Input.GetAxis("ControllerX"), Input.GetAxis("ControllerY"));

        //Player movement/rotation control
        //move the player if they're pushing the arrow keys or wasd
        if (input.x != 0) bod.AddForce(Vector2.right * moveSpd * Time.deltaTime * input.x);
        if (input.y != 0) bod.AddForce(Vector2.up * moveSpd * Time.deltaTime * input.y);

        //This chunk checks for what the player is pressing and rotates the
        //sprites into one of the 8 directions possible

        //Right(no rotation)
        if (input.x > 0 && input.y == 0) transform.rotation = Quaternion.Euler(0, 0, 0);
        //Left
        else if (input.x < 0 && input.y == 0) transform.rotation = Quaternion.Euler(0, 0, 180);
        //Up
        else if (input.y > 0 && input.x == 0) transform.rotation = Quaternion.Euler(0, 0, 90);
        //Down
        else if (input.y < 0 && input.x == 0) transform.rotation = Quaternion.Euler(0, 0, 270);
        //Up-right
        else if (input.x > 0 && input.y > 0) transform.rotation = Quaternion.Euler(0, 0, 45);
        //Up-left
        else if (input.x < 0 && input.y > 0) transform.rotation = Quaternion.Euler(0, 0, 135);
        //Down-left
        else if (input.x < 0 && input.y < 0) transform.rotation = Quaternion.Euler(0, 0, 225);
        //Down-right
        else if (input.x > 0 && input.y < 0) transform.rotation = Quaternion.Euler(0, 0, 315);

    }
}
