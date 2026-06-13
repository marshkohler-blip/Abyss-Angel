using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] public int speed = 5;

    public int sideDirection = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.dKey.wasPressedThisFrame){
            sideDirection = 1;
        }
         if(Keyboard.current.aKey.wasPressedThisFrame){
            sideDirection = -1;
        }
        if(!Keyboard.current.dKey.isPressed && !Keyboard.current.aKey.isPressed){
            sideDirection = 0;
        }
       // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * sideDirection * speed * Time.deltaTime);
        
    }
}
