using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawler : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player; // Referencia al jugador
    public float speed = 2.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
        
        

    }

    void onCatchPlayer()
    {
        return;
    }
}
