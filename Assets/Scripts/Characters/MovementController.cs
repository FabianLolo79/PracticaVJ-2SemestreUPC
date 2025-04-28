using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour
{
    // Referecia al scriptableObject
    [SerializeField] private CharacterStats_SO _stats;
    private Rigidbody2D _rb;
    private Vector2 _direction;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        _direction = direction.normalized;
        _rb.linearVelocity = _direction * _stats.Speed;
    }
}
