using UnityEngine;

public class ManagementPanel : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject defeatPanel;

    private void OnEnable()
    {
        Health.OnDefeat += Defeat;
        WinGame.OnWin += Win;
    }

    private void OnDisable()
    {
        Health.OnDefeat -= Defeat;
        WinGame.OnWin -= Win;
    }


    private void Win()
    {
        winPanel.SetActive(true);
    }
    private void Defeat()
    {
        defeatPanel.SetActive(true);
    }
}
