using UnityEngine;
using System.Collections;

public class FireDestroyer : MonoBehaviour {

    void OnTriggerEnter (Collider ouch)
    {
        Debug.Log("WTF!!!");
        Debug.Log(ouch.gameObject);
        Destroy(ouch.gameObject);
    }
}
