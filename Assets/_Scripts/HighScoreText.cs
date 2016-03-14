using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HighScoreText : MonoBehaviour {

    void Start()
    {
        GameState state = GameObject.FindObjectOfType<GameState>();
        Text text = GetComponent<Text>();
        text.text = "High Score: " + state.highScore + " meters.";
    }
}
