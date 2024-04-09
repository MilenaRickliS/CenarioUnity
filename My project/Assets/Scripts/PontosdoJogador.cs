using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosdoJogador : MonoBehaviour
{
    public static PontosdoJogador instance;

    public GameOverScrem gameOverScrem;
    public Text pontosMax;
    public Text pontosAtual;

    int score = 100;
    int highscore = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        pontosAtual.text = score.ToString() + " POINTS";
        pontosMax.text = "HIGHSCORE: " + highscore.ToString();
    }


    public void ReceberDano(){
        score -=1;
        pontosAtual.text = score.ToString() + " POINTS";

    }
    public void gameOver(){
        gameOverScrem.Setup(score);
    }
}
