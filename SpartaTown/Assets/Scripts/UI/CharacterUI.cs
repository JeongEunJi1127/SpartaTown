using UnityEngine;
using UnityEngine.UI;

public class CharacterUI : MonoBehaviour
{
    [SerializeField] private Text characterName;
    private void Awake()
    {
        characterName.text = GameManager.Instance.Name;
    }
}
