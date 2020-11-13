using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//dependencies

public class Character : MonoBehaviour // Script identifier
{
    // Updates only in the beginning
    void Start()
    {
        /*QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 120;*/
		// these lines serve to define the framerate but it does not need to be this high
    }

    // Updates every second
    void Update()
    {
	    float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		// define which axis is going to be used
		
        Vector2 position = transform.position;
		// defines the vector2 position as transform.position
		position.x = position.x + 3.0f * horizontal * Time.deltaTime;
		// line that defines how the character moves in the X axis
		position.y = position.y + 3.0f * vertical * Time.deltaTime;
		// line that defines how the character moves in the Y axis
		transform.position = position;
		// checks the position once again and updates it
    }
}
/* by making the character move using an axis based code, we only need to define which keys in the project setting menu in unity. This is better than hardcoding it because it provides the player a choice to
use what keys they want to use to move.*/