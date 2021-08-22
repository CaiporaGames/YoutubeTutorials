using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.scaleX(gameObject, 5, 5);
        //LeanTween.scale(gameObject, new Vector3(5,3,1), 5);
        LeanTween.scale(gameObject, new Vector3(5,3,1), 5).setDestroyOnComplete(gameObject);
    } 
}
