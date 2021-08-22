using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.move(gameObject.GetComponent<RectTransform>(), new Vector3(200f, -100f, 0f), 1f).setDelay(1f);
        LeanTween.move(gameObject.GetComponent<RectTransform>(), new Vector3(200f, -100f, 0f), 1f).setDelay(1f).setOnComplete(Effect);
    }  
    

    void Effect()
    {
        LeanTween.scale(gameObject,new Vector3(3,3,1), 3).setEaseInBounce();
    }
}
