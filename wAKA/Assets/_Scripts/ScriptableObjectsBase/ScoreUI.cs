using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public int s;
    void Update()
    {
        s = FindObjectOfType<CastorBehavior>().score;
    }
}