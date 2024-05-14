using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    [SerializeField] private Text characterName;
    [SerializeField] public GameObject[] Character;

    private void Awake()
    {
        EnableCharacter();
        UpdateName();
    }

    public void EnableCharacter()
    {
        Character[(int)GameManager.Instance.playerSO.job].SetActive(true);
    }

    public void UpdateName()
    {
        if(!string.IsNullOrEmpty(characterName.ToString()))
        {
            characterName.text = GameManager.Instance.playerSO.name;
        }
    }

    public void UpdateJob()
    {    
        Character[1-(int)GameManager.Instance.playerSO.job].SetActive(false);
        Vector3 nowPos = Character[1 - (int)GameManager.Instance.playerSO.job].transform.position;
        Character[(int)GameManager.Instance.playerSO.job].SetActive(true);
        Character[(int)GameManager.Instance.playerSO.job].transform.position = nowPos;
    }
}
