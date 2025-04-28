using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "Scriptable Objects/Character/Stats")]
public class CharacterStats_SO : ScriptableObject
{
    [Header("Movement")]
    [SerializeField] private string _characterName;
    [SerializeField] private int _health;
    [SerializeField] private float _speed;

    //Propiedades públicas
    public string CharacterName => _characterName;
    public int Health => _health;
    public float Speed => _speed;

}
