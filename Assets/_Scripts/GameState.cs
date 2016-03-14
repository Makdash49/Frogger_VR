using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

    public int highScore;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void update() {

    }

    public void UpdateHighScore(int newScore)
    {
        if (newScore > highScore)
         {
            highScore = newScore;
         }
    }
}
