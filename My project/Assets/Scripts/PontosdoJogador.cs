using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosdoJogador : MonoBehaviour
{
    // public static PontosdoJogador instance;
    public Text pontosMax;
    public Text pontosAtual;

    int score = 0;
    int highscore = 0;

    // private void Awake(){
    //     // instance = this;
    // }

    // Start is called before the first frame update
    void Start()
    {
        pontosAtual.text = score.ToString() + " POINTS";
        pontosMax.text = "HIGHSCORE: " + highscore.ToString();
    }


    // public void ReceberDano(){
    //     score -=1;

    //     if(score <= 0){
    //         Debug.Log("game over");
    //     }
    // }
}
