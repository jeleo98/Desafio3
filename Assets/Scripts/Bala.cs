using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int Attack = 3;
    public Vector3 Direction = new Vector3 (0.4f,0.2f,0.5f);
    public float Speed = 2;
    public float posicionY = 1.35f;
    public float posicionX = 1.2f;
    public float posicionZ = 3.98f;
    private Vector3 InitialPosition = new Vector3 (1.16f, -1.59f, -2.33f);
    // Start is called before the first frame update
    void Start()
    {
       transform.position = new Vector3 (1.2f, 1.35f, 3.98f);
    }

    // Update is called once per frame
    void Update()
    {
         Move();
    }

    private void Move () 
    {
        transform.position += Direction * Speed * Time.deltaTime;
    }
}
