using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        if (null == player)
        {
            Debug.LogError("player is not assigned. Aborting");
            return;
        }
            

        offset = transform.position - player.transform.position;
    }


    void LateUpdate()
    {
        if (null == player)
            return;

        transform.position = player.transform.position + offset;
    }
}
