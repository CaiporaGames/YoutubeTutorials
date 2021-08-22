using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateAround(gameObject, new Vector3(0, 0, 1),360, 2).setOnComplete(Delay).setDelay(2);
    }

    void Delay()
    {
        LeanTween.rotateAround(gameObject, new Vector3(0, 0, 1), 360, 2).setOnComplete(Start).setDelay(2);
    }
}
