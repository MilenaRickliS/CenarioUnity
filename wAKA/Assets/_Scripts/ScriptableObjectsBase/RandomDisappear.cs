using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisappear : MonoBehaviour
{
    public float disappearTime = 5f; // Time until the object disappears
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= disappearTime)
        {
            Destroy(gameObject);
        }
    }
}