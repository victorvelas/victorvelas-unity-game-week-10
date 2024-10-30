using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject objectToLook;

    [SerializeField]
    //private float yPos;

    private Vector3 objectToLookPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        look();
    }

    private void look()
    {
        objectToLookPosition = objectToLook.transform.position;
        objectToLookPosition.y = 0.75f;
        transform.LookAt(objectToLookPosition);
    }
}
