using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    public ScoreCount ScoreCount;
    private int faithNeeded = 5000;
    private bool listenerAdded = false;

    private void Update()
    {
        if (!listenerAdded && ScoreCount.GetFaithScore() > faithNeeded)
        {
            GetComponent<Button>().onClick.AddListener(OnPurchaseLast);
            listenerAdded = true;
        }
    }

    public void OnPurchaseLast()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
