using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{

    public static LevelController instancia;
    public Button[] levelButtons;
    public int desbloqLevels;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(levelButtons.Length > 0)
        {
            for (int i = 0; i < levelButtons.Length; i++)
            {
                levelButtons[i].interactable = false;
            }

            for (int i = 0; i < PlayerPrefs.GetInt("nivelesDesbloqueados", 1); i++)
            {
                levelButtons[i].interactable = true;
            }
        }
    }

    public void AddLevels()
    {
        if (desbloqLevels > PlayerPrefs.GetInt("nivelesDesbloqueados", 1))
        {
            PlayerPrefs.SetInt("nivelesDesbloqueados", desbloqLevels);
        }
    }
}
