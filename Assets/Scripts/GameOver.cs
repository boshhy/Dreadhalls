using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // If player falls below -4 on the y position destroy the audio source
        // and go to game over scene
        if (transform.position.y < -4){
            Destroy(GameObject.FindWithTag("WhisperSource"));
            SceneManager.LoadScene("GameOver");
        }
    }
}
