using UnityEngine;

public class Level : MonoBehaviour
{
    // Serialized for debugging purposes
    [SerializeField] private int _breakableBlocks;

    public void CountBreakableBlocks()
    {
        _breakableBlocks++;
    }
}
