using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        //Deltatime pour que la rotation soit indépendante de la frame, sinon c'est trop rapide
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime) ;
	}
}
