using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class playerScript1 : MonoBehaviour
{
    private float movementX;
    private float movementY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed = 5f;
    void OnMove(InputValue val)
    {
        Vector2 vec = val.Get<Vector2>();
        Debug.Log(vec);

        movementX = vec.x;
        movementY = vec.y;
        
    }
    
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        float xMoveDistance = movementX * speed * Time.fixedDeltaTime;
        float yMoveDistance = movementY * speed * Time.fixedDeltaTime;

        transform.position = new Vector2(transform.position.x + xMoveDistance, 
                                        transform.position.y + yMoveDistance);
    }
}
