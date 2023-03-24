using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
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
        currLevel = LevelGenerator.level;
        myText.text = "Level: " + currLevel.ToString();
    }
}
