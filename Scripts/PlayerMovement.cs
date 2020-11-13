using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{

    public Vector2 playerPos;
    public float moveYaxis;
    public float moveXaxis;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public float maxWidth;
    public float minWidth;

    private void Update()
   {
    
		  
    transform.position = Vector2.MoveTowards(transform.position, playerPos,speed*Time.deltaTime);
	
   {
 
 if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
            {
                playerPos = new Vector2(transform.position.x, transform.position.y + moveYaxis);
            }
   
   else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
            {
                playerPos = new Vector2(transform.position.x, transform.position.y - moveYaxis);
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.y > minWidth)
            {
                playerPos = new Vector2(transform.position.x, transform.position.y - moveXaxis);
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.y > maxWidth)
            {
                playerPos = new Vector2(transform.position.x, transform.position.y + moveXaxis);
            }

        }
   
}
}