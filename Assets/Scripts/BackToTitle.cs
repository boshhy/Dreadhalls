using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If user hits enter, reset level counter to 0 and go back to title screen
        if (Input.GetAxis("Submit") == 1) {
            LevelGenerator.level = 0;
			SceneManager.LoadScene("Title");
		}
    }
}
