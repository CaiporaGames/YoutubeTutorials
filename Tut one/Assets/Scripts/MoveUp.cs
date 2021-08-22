using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    // Start is called before the first frame update
    void Start()
    {
        //LeanTween.moveLocalY(gameObject, 1, 2);
        //LeanTween.moveLocalY(gameObject, 1, 2).setEase(curve);
        //LeanTween.moveLocalY(gameObject, 1, 2).setOnComplete(Log);
        //LeanTween.moveLocalY(gameObject, 1, 2).setLoopPingPong();
        //LeanTween.moveLocalY(gameObject, 1, 0.5f).setLoopPingPong();//menor tempo
        //LeanTween.move(gameObject, new Vector3(1, 1, 0), 2).setLoopPingPong();
        //LeanTween.move(gameObject, new Vector3(1, 1, 0), 5).setEasePunch();
        //LeanTween.move(gameObject, new Vector3(1, 1, 0), 5).setEaseShake();
        //LeanTween.move(gameObject, new Vector3(3, 3, 0), 5).setEaseSpring();
    }

    void Log()
    {
        Debug.Log("Moveimento Terminado");
    }
}
