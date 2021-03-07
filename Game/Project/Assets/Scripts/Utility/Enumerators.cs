using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MikeEvans
{
    /// <summary>
    /// When calling methods, be sure to use StartCoroutine(method)
    /// </summary>
    public class Enumerators : MonoBehaviour
    {
        public static IEnumerator WaitToCall(float timeToWait, Action callbackAction)
        {
            yield return new WaitForSeconds(timeToWait);

            callbackAction();
        }
    }
}
