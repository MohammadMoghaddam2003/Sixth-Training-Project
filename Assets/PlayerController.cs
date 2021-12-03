using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1f, 25f)]
    public float WalkSpeed = 10;


    CharacterController _characterController;





    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _characterController.Move(Vector3.Lerp(
                    new Vector3(0, 0, 0), new Vector3(0, 0, WalkSpeed * Time.deltaTime), 3f
                    ));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _characterController.Move(Vector3.Lerp(
                   new Vector3(0, 0, 0), new Vector3(0, 0, -WalkSpeed * Time.deltaTime), 3f
                   ));
        }

        if (Input.GetKey(KeyCode.A))
        {
            _characterController.Move(Vector3.Lerp(
                   new Vector3(0, 0, 0), new Vector3(-WalkSpeed * Time.deltaTime, 0, 0), 3f
                   ));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _characterController.Move(Vector3.Lerp(
                    new Vector3(0, 0, 0), new Vector3(WalkSpeed * Time.deltaTime, 0, 0), 3f
                    ));
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            WalkSpeed *= 2;
        }
        else
        {
            
        }
    }
}
