using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchRoomController : MonoBehaviour
{
    public float t;
    public bool move = false;

    void Update()
    {
        if (move) Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z), t * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            move = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            move = false;
        }
    }
}
