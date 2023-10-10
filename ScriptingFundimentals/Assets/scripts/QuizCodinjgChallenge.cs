using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuizCodinjgChallenge : MonoBehaviour
{
    public int score = 0;
    public string Playername = "Justin";
    public int Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        Increasescore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void Increasescore()
    {
        score += 10;
    }
    private void PrintPlayerName()
    {
        Debug.Log(Playername);
    }

    private void DecreaseHealth()
    {
        Health = -20;
    }
}