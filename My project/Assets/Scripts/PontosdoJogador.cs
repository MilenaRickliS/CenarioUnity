using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PontosdoJogador : MonoBehaviour
{
    
    public Text PontosPlayer;
    int score = 100;
    public Transform startPosition;

    void onCollisionEnter(Collider collider){
        if(collider.gameObject.CompareTag("Lava")){
            score -= 100;
            PontosPlayer.text = score + " POINTS";
            transform.position = startPosition.position;
        }
    }

    void Update(){
        if(score <= 0){
            Time.timeScale = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
   
    
}
