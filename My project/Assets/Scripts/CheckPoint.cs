using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkpoint;
    [SerializeField] Vector3 vector3;
    [SerializeField] float dead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -dead){
            player.transform.position = vector3;
        }
    } 
    
    private void OnTriggerEnter(Collider other){
        vector3 = player.transform.position;
        Destroy(other.gameObject);
    }
}
