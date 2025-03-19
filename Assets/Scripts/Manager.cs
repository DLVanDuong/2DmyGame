using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    private int Score = 0;
    [SerializeField] private TextMeshProUGUI Scoretext;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(int point)
    {
        Score += point;
        UpdateScore();
    }
    private void UpdateScore()
    {
        Scoretext.text = Score.ToString();
    }
}
