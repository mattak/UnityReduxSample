using UnityEngine;
using UnityEngine.UI;

public class NormalCounter : MonoBehaviour
{
    public Button countUpButton;
    public Button countDownButton;
    public Text text;
    private int count;

    void Start()
    {
        count = 0;
        countUpButton.onClick.AddListener(() =>
        {
            count++;
            text.text = count.ToString();
        });
        countDownButton.onClick.AddListener(() =>
        {
            count--;
            text.text = count.ToString();
        });
    }
}