using UnityEngine;

[CreateAssetMenu(menuName ="enemyNumbers")]
public class enemyTracker : ScriptableObject
{
    public int enemyNumbers;
    private void Awake()
    {    
        enemyNumbers = 0;
    }
    public void addOne()
    {
        enemyNumbers++;
        Debug.Log(enemyNumbers);
    }
}
