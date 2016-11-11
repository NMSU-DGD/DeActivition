using UnityEngine;
using System.Collections;

public class pickupscript : MonoBehaviour {
    int count;
	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Destroy(hit.gameObject);
        count++;
        Debug.Log("sphere grab =" + count);
    }
}
