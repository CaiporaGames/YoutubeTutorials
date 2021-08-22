using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeMovements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.rotateAround(gameObject, new Vector3(0,0,1), 360, 2).setOnComplete(Translate).setDelay(2);
    }  

    void Translate()
    {
        //LeanTween.move(gameObject, new Vector3(1,1,0), 3).setLoopPingPong().setDelay(2).setOnComplete(Scaler);//on complete nao é chamada
        //LeanTween.move(gameObject, new Vector3(1,1,0), 3).setDelay(2);//Nao da certo duas funcoes seguidas
        LeanTween.move(gameObject, new Vector3(1,1,0), 3).setDelay(2).setOnComplete(Translate2);
    }

    void Translate2()
    {        
        LeanTween.move(gameObject, new Vector3(-1, -1, 0), 3).setDelay(2).setOnComplete(Scaler);
    }

    void Scaler()
    {
        LeanTween.scale(gameObject, new Vector3(3, 3, 1), 5).setDelay(2).setOnComplete(Start);//Temos que regressar o valor para poder funcionar.
    }
}
