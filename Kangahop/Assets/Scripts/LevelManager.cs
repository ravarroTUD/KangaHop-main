using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    private int steps;
    public int stepsForMoreLanes = 12;
    private int currentSteps;
    public Text stepScore;
    public Text gameOverText;

    // Start is called before the first frame update
    void Awake()
    {
        levelManager = this;
    }

    // Update is called once per frame
    void Update() 
    { 
        
    }

    // Create more lanes when couple of steps is taken. Score will also be counted to the score text
    public void SetSteps()
    {
        steps++;
        stepScore.text = steps.ToString();
        currentSteps++;

        if (currentSteps > stepsForMoreLanes)
        {
            currentSteps = 0;
            GetComponent<CreateLevels>().CreateLanes();
        }
    }

    // Display Game Over screen
    public void GameOver()
    {
        gameOverText.text = "Game Over \nYour Score: " + steps.ToString();
        Invoke("ReloadScene", 3f);
    }

    // Scene will reload from the Game Over screen after a few seconds
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
