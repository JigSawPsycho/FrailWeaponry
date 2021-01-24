using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Turret : MonoBehaviour
{
    [SerializeField] float damage;
    float health;
    float rateOfFire;
    float range;
    enum TurretType
    {
        Machinegun,
        Sniper,
        Zapper
    }
    
    bool broken = false;

    Vector2 pos;

    [SerializeField] GameObject currentTarget = null;

    private void Start()
    {
        pos = this.gameObject.transform.position;
        InvokeRepeating(nameof(CheckForTarget), 0.1f, 0.1f);
        Activate(TurretType.Zapper);
    }

    private void Update()
    {
        if (!broken)
        {
            if (health <= 0)
            {
                Break();
            }

            if(currentTarget != null)
            {
                //var lookTransform = currentTarget.transform.position;
                //lookTransform.z = transform.position.z;
                //
                //gameObject.transform.LookAt(lookTransform);
                //
                //Quaternion lockedRot = new Quaternion(0, 0, transform.rotation.z, 1);
                //
                //transform.SetPositionAndRotation(pos, lockedRot);

                float angle = 0;

                Vector3 relative = transform.InverseTransformPoint(currentTarget.transform.position);
                angle = Mathf.Atan2(relative.x, relative.y) * Mathf.Rad2Deg;
                transform.Rotate(0, 0, -angle);

                if (Vector2.Distance(currentTarget.transform.position, pos) > range)
                {
                    currentTarget = null;
                }
            }
        }
    }

    void CheckForTarget()
    {
        if (currentTarget != null && broken == false)
        {
            return;
        }
        GameObject[] objsInRange = Physics2D.OverlapCircleAll(pos, range).Select(x => x.gameObject).ToArray();
        GameObject closestTarget = null;

        foreach(GameObject obj in objsInRange)
        {
            if (obj == gameObject)
                continue;

            if(obj.CompareTag("Enemy"))
            {
                
                if (closestTarget == null)
                {
                    closestTarget = obj;
                    currentTarget = obj;
                    continue;
                }
                else
                {
                    if (Vector2.Distance(closestTarget.transform.position, pos) > Vector2.Distance(obj.transform.position, pos))
                    {
                        closestTarget = obj;
                        currentTarget = obj;
                    }
                }
            }
        }
    }

    void Shoot()
    {
        Debug.Log("Pew");
        if (currentTarget != null && broken == false)
        {
            currentTarget.GetComponent<enemyHealth>().GetHit(damage);
        }

        Invoke(nameof(Shoot), rateOfFire);
    }

    void Activate(TurretType type)
    {
        switch(type)
        {
            case TurretType.Machinegun:
                health = 10f;
                damage = 0.5f;
                rateOfFire = 0.3f;
                range = 10f;
                break;

            case TurretType.Sniper:
                health = 25f;
                damage = 10f;
                rateOfFire = 2f;
                range = 20f;
                break;

            case TurretType.Zapper:
                health = 20f;
                damage = 5f;
                rateOfFire = 1f;
                range = 5f;
                break;
        }

        Invoke(nameof(Shoot), 0.5f);

        broken = false;
    }

    void Break()
    {
        //broken = true;
    }

    void Decay()
    {

    }
}
