using UnityEngine;
using System.Collections;

public class charactermovementscript : MonoBehaviour {
    private Animator animator;
    private int lane;

	// Use this for initialization
	void Start () {
       lane = 0;
        animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("jumping", true);
            Invoke("stopJumping", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("sliding", true);
            Invoke("stopSliding", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(lane > -6)
            {
                lane=lane-6;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("right", true);
            if (lane < +6)
            {
                lane=lane+6;
            }
        }
        Vector3 newPosition = transform.position;
        newPosition.x = lane;
        transform.position = newPosition;
	}
    
    void stopJumping()
    {
        animator.SetBool("jumping", false);
    }
    void stopSliding()
    {
        animator.SetBool("sliding", false);
    }
}
