using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float Delay;
    public GameObject completeLevelUI;
    public AudioSource audioPlayer;
    public AudioSource backgroundPlayer;



    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }



    public void GameOver()
    {
        //This gets called on collision.  We want this to only be called once since multiple collisions might happen at once.
        if (gameEnded == false)
        {
            gameEnded = true;
            backgroundPlayer.Stop();
            audioPlayer.Play();
            //Invoke will call 1st parameter after delay amount of time
            Invoke("RestartGame", Delay);
            
        }
        


    }



    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
