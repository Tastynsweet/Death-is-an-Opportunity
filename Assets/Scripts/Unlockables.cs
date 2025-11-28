using UnityEngine;

[System.Serializable]
public class Upgrades
{
    public GameObject gameobj;
    [HideInInspector] public GameObject instance;
    public bool isUnlocked = false;
    public int faithPoints;
    public float passiveRate;
    public int faithRequired;

    public void Initialize(Transform parent = null)
    {
        if (gameobj != null)
        {
            instance = Object.Instantiate(gameobj, parent);
            instance.SetActive(false);
        }
    }

    public void Appear()
    {
        if (instance != null)
        {
            instance.SetActive(true);
        }
    }
}

public class Unlockables : MonoBehaviour
{
    public Upgrades[] upgradeLists;
    public ScoreCount scoreCount;

    void Start()
    {
        for (int i = 0; i < upgradeLists.Length; i++)
        {
            upgradeLists[i].Initialize();
        }
    }
}
