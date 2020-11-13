using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencies

public class PlayerMovement : MonoBehaviour //Identifier
{

    public Vector2 playerPos;
    public float moveYaxis;
    public float moveXaxis;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public float maxWidth;
    public float minWidth;
	private float targetTime = 0.0f;
	//Variables

    private void Update()
		//Update every second
   {
     targetTime += Time.deltaTime;
		// targetTime identifier
		  
    transform.position = Vector2.MoveTowards(transform.position, playerPos,speed*Time.deltaTime);
		//Line that defines what transform.position is
	
if (targetTime >= 1.0f)
	//cooldown
   {
 
 if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
            {
                playerPos = new Vector2(transform.position.x, transform.position.y + moveYaxis);
            }
	//hardcodes the character to move up when the up arrow key is pressed
   
   else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
            {
                playerPos = new Vector2(transform.position.x, transform.position.y - moveYaxis);
            }
	//hardcodes the character to move down when the down key is pressed

   else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minWidth)
            {
                playerPos = new Vector2(transform.position.x - moveXaxis, transform.position.y);
            }
	//hardcodes the character to move left when the left key is pressed

   else if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x > maxWidth)
            {
                playerPos = new Vector2(transform.position.x + moveXaxis, transform.position.y);
            }
	//hardcodes the character to move right right when the right key is pressed

        }
   
}
}