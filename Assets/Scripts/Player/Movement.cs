using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
            // This Variable is visible in the Inspector and is only ACCESSIBLE in this Script.
            // It is of type Float (decimal numbers).
            
        private Rigidbody2D _rigidbody2D;
            // This Variable is invisible in the Inspector and is only ACCESSIBLE in this Script;
            // It is of type RigidBody2D, which means it can only hold a RigidBody2D Component
            
        private Vector2 _movement;
            // This Variable is invisible in the Inspector and is only ACCESSIBLE in this Script.
            // It is of type Vector2, it contains two Floats (x & y).
        
        private void Start() => _rigidbody2D = GetComponent<Rigidbody2D>();
            // This function is CALLED at the moment a object is created in the scene
            // In this function we GET the RigidBody2D Component and ASSIGN it to a variable
            
        private void FixedUpdate() => _rigidbody2D.velocity = _movement * moveSpeed;
            // This function is CALLED 50 times per second
            // In it we update our physics velocity with the value of our input
            // and multiply it with a set speed
            
        private void OnMove(InputValue value) => _movement = value.Get<Vector2>();
            // This function is CALLED each time you interact with a Input (keyboard/gamepad)
            // In it we GET the value of our Input and ASSIGN it to a variable
    }
}