using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleted : MonoBehaviour
{
    int currLevel;
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
        // get current level and display level on Gameover scene
        currLevel = LevelGenerator.level;
        myText.text = "You made it to level: " + currLevel.ToString();
    }
}
