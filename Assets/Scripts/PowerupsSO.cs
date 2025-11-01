using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerupsSO", menuName = "PowerupsSO")]
public class PowerupsSO : ScriptableObject
{
    [SerializeField] string powerupType;
    [SerializeField] float valueChange;
    [SerializeField] float time;

    public string GetPowerupType()
    {
        return powerupType;
    }

    public float GetValueChange()
    {
        return valueChange;
    }

    public float GetTime()
    {
        return time;    
    }
}
