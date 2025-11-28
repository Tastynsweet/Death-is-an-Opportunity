using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public int faithCount;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !ShopMenu.onMenu)
        {
            faithCount++;
        }
    }

    public int GetFaithScore()
    {
        return faithCount;
    }

    public void AddFaith(int faith)
    {
        faithCount = faith + faithCount;
    }

    public void RemoveFaith(int faith)
    {
        faithCount = faithCount - faith;
    }
}
