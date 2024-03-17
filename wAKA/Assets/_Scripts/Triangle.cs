using System.Collections;
using UnityEngine;

namespace Assets._Scripts
{
    public class Triangle : MonoBehaviour, ITocavel
    {
        public void Tocar()
        {
            var spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.color = spriteRenderer.color == Color.red ? Color.white : Color.red;
            var randomDestination = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width * Random.value, Screen.height * Random.value, 0));
            randomDestination.z = 0;
            transform.position = randomDestination;
        }
    }
}