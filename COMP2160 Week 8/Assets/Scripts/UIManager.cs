using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Coin coin;
    //[SerializeField] private int score;

    public Text text;
    public int score = 0;

    ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        SetText();
    }

    public void SetText()
    {
        text.text = "Score : " + scoreKeeper.point.ToString();
    }
}
