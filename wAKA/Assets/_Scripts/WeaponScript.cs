using System.Collections;
using UnityEngine;

namespace Assets._Scripts
{
    public class WeaponScript : MonoBehaviour
    {
        public Weapon weapon;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(Shoot());
            }
        }

        public IEnumerator Shoot()
        {
            //logica de tiro
            yield return new WaitForSeconds(this.weapon.FireRate / 60);
        }
    }
}