using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 3f;
    private Rigidbody2D _playerRb;
    private Vector2 _moveInput;
    private Animator _playerAnimator;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerRb = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        _moveInput = new Vector2(moveX, moveY).normalized;

        _playerAnimator.SetFloat("Horizontal", moveX);
        _playerAnimator.SetFloat("Vertical", moveY);
        _playerAnimator.SetFloat("Speed", _moveInput.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        _playerRb.MovePosition(_playerRb.position + _moveInput * _moveSpeed * Time.fixedDeltaTime);
    }
       
}
