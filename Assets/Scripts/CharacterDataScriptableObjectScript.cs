using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDataScriptableObjectScript", menuName = "Scriptable Objects/CharacterDataScriptableObjectScript")]
public class CharacterDataScriptableObjectScript : ScriptableObject
{
    
    [SerializeField] private string _characterName;
    [SerializeField] private int _health;
    [SerializeField] private float _speed;

    private Vector2 _direction;

    // Propiedades públicas para acceder a los campos privados
    public string CharacterName
    {
        get { return _characterName; }
    }

    public int Health
    {
        get { return _health; }
    }

    public float Speed
    {
        get { return _speed; }
    }
}
