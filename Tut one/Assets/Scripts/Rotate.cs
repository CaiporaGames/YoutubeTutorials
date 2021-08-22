using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //LeanTween.rotateX(gameObject, 90, 2);//Ao contrario da regra da mao direita.
        //LeanTween.rotateX(gameObject, -90, 2);//Funciona em coordenadas locais
        //LeanTween.rotateX(gameObject, 180, 2);
        //LeanTween.rotateX(gameObject, 270, 2);
        //LeanTween.rotateX(gameObject, 360, 2);
        //LeanTween.rotate(gameObject, new Vector3(0, 90, 180), 2);
        //LeanTween.rotate(gameObject, new Vector3(180, 90, 0), 2);
        //LeanTween.rotate(gameObject, new Vector3(180, 90, 0), 2).setLoopPingPong();
        //LeanTween.rotateAround(gameObject, new Vector3(0, 0, 1),360, 2);//Funciona em coordenadas globais
        //LeanTween.rotateAround(gameObject, new Vector3(0, 0, 1), 360, 2).setRepeat(3);
        //LeanTween.rotateAround(gameObject, new Vector3(0, 0, 1),360, 2).setLoopClamp();
        LeanTween.rotateAround(gameObject, new Vector3(0, 0, 1),360, 2).setLoopClamp().setDelay(2);
    }
}
