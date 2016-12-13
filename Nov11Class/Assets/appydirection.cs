using UnityEngine;
using System.Collections;

public class appydirection : MonoBehaviour {
    public Vector3 direction;

    //Whether or not we want to use discrete-styled movement
    public bool isDiscrete = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (true == Input.GetKeyDown(KeyCode.Space)) {
            if (isDiscrete)
            {
                transform.localPosition += direction;
            }
            else {
                //Stores any info relevant to a collision
                RaycastHit hit;
               bool didHit= Physics.Raycast(transform.position,//where we start the ray from
                    direction,//direction of the ray
                    out hit,//variable to store results of any collision
                    direction.magnitude,//length of the ray
                    LayerMask.NameToLayer("Default"));//layer we want to collide
                if (didHit) {
                    Debug.Log("DID HIT! BITCH");
                }
            }
        }
	}
}
