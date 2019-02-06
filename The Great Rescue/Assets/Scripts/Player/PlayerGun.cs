using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    private float firerate = 0.0f; //Change to change firerate

    [SerializeField]
    private float damage = 0; //Damage not used for now

    [SerializeField]
    private LayerMask whatToHit; //Remember to include layers that should be able to be hit

    [SerializeField]
    private Transform BulletPrefab;

    Transform firePoint;

    float fireTimer = 0;

    void Awake()
    {
        //Remember to add an empty child to the gun called "FirePoint"
        firePoint = transform.Find("FirePoint");
    }

    void Update()
    {
        if (firerate == 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Shoot();
            }
            else
            {
                if (Input.GetKey(KeyCode.Space) && Time.time > fireTimer)
                {
                    fireTimer = Time.time + 1 / firerate;
                    Shoot();
                }
            }
        }
    }

    void Shoot()
    {
        //Raycasting
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition - firePointPosition, 100, whatToHit);

        Effect();
    }

    void Effect()
    {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }
}
