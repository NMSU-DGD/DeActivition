using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {
    private CharacterController controller;
    private float speed = 10.0f;
	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        controller.Move((Vector3.forward *speed) * Time.deltaTime);
	}
}
