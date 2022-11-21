using System.Collections;
using System.Collections.Generic;
using Extensions;
using UnityEngine;

public class ShootOnClick : MonoBehaviour
{
    public GameObject projectile;
    public float shootRate = 0.25f;

    private bool _canShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (_canShoot && Input.GetMouseButton(0))
        {
            var myTransform = transform;
            var myPosition = myTransform.position;

            Instantiate(projectile, (myPosition + myTransform.forward).AtY(0.5f), myTransform.rotation);
            StartCoroutine(ShootCooldownRoutine());
        }
    }

    private IEnumerator ShootCooldownRoutine()
    {
        _canShoot = false;
        yield return new WaitForSeconds(shootRate);
        _canShoot = true;
    }
}