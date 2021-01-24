using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Turret : MonoBehaviour
{
    int damage;
    int health;
    float rateOfFire = 1f;
    float range = 10f;
    
    bool broken = false;

    Vector2 pos;

    [SerializeField] GameObject currentTarget = null;

    private void Start()
    {
        pos = this.gameObject.transform.position;
        InvokeRepeating(nameof(CheckForTarget), rateOfFire, rateOfFire);
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
        if (currentTarget != null)
        {
            Shoot(currentTarget);
            return;
        }
        GameObject[] objsInRange = Physics2D.OverlapCircleAll(pos, range).Select(x => x.gameObject).ToArray();
        Debug.Log($"Targets: {objsInRange.Length}");
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
        if (closestTarget != null)
        {
            Shoot(closestTarget);
        }
    }

    void Shoot(GameObject target)
    {
        T 
    }

    void Break()
    {
        //broken = true;
    }

    void Decay()
    {

    }
}
