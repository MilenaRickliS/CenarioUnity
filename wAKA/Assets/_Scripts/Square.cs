using UnityEngine;

namespace Assets._Scripts
{
    public class Square : MonoBehaviour, ITocavel
    {
        public void Tocar()
        {
            var spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.color = spriteRenderer.color == Color.blue ? Color.white : Color.blue;
            this.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        }
    }
}