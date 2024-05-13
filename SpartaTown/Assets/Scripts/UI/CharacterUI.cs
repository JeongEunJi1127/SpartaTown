using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    [SerializeField] private Text characterName;

    private void Start()
    {
        if (characterName.text != null)
        {
            characterName.text = GameManager.Instance.playerSO.name;
        }
    }
}
