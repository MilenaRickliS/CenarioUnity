using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkpoint;
    [SerializeField] Vector3 vector3;
    [SerializeField] float dead;
    

    // // Update is called once per frame
    // void Update()
    // {
    //     if(player.transform.position.y < -dead){
    //         player.transform.position = vector3;
    //     }
    // } 
    
    private void OnTriggerEnter(Collider other){
        player.transform.position = vector3;
    }
}
