using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 2f;
    

    
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed *Time.deltaTime);
        CharacterTurn();
    }

    private void CharacterTurn()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * turnSpeed *Time.deltaTime, 0,0);
    }
}
