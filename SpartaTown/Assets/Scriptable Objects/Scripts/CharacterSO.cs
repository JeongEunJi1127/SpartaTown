using UnityEngine;

[CreateAssetMenu(fileName ="CharacterSO", menuName ="Controller/CharacterSO/Player", order =0)]
public class CharacterSO : ScriptableObject
{
    [Header("Character")]
    public string name;
    public Character.JobType job;
    public int speed;
    
}
