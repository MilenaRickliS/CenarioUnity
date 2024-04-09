using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public GameObject player;
    
    

    // private void OnTriggerEnter(Collider other){
    //     if(other.gameObject.CompareTag("Player")){
    //         PontosdoJogador.instance.ReceberDano();
    //     }
    // }
//     void OnPlayerEnter(PlayerController player){
//         PontosdoJogador.instance.ReceberDano();
//     }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            PontosdoJogador.instance.ReceberDano();
        }
    }
}
