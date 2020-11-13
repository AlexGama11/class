using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{

public GameObject MenuPanel;


    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
	
        if (Input.GetKeyDown(KeyCode.Escape))
		{
		    MenuPanel.SetActive(true);
		}
		
		else if (Input.GetKeyDown(KeyCode.Backspace))
		{
		    MenuPanel.SetActive(false);
		}
	
		
	}
}