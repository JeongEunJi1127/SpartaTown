using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    [SerializeField] private Text characterName;
    [SerializeField] public GameObject[] Character;

    private void Awake()
    {
        EnableCharacter();
    }

    public void EnableCharacter()
    {
        Character[(int)GameManager.Instance.playerSO.job].SetActive(true);
    }

    public void UpdateName()
    {
        characterName.text = GameManager.Instance.playerSO.name;
    }

    public void UpdateJob()
    {
        Character[1-(int)GameManager.Instance.playerSO.job].SetActive(false);
        Character[(int)GameManager.Instance.playerSO.job].SetActive(true);
    }
}
