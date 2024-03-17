using UnityEngine;

namespace Assets._Scripts.Managers
{
    public class TouchManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                var obj = Physics2D.OverlapPoint(mousePosition);
                if (obj != null)
                {
                    if (obj.gameObject.TryGetComponent<ITocavel>(out var touchable))
                    {
                        touchable.Tocar();
                    }
                }
            }
        }
    }
}