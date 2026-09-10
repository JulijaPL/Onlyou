using TMPro;
using UnityEngine;

public class teethManager : MonoBehaviour
{
    public static teethManager Instance;

    [SerializeField] private TextMeshProUGUI teethCount;
    private int teeth;
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        teeth = PlayerPrefs.GetInt("Teeth", teeth);
        UpdateTeethUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTeeth(int amount)
    {
        teeth += amount;
        PlayerPrefs.SetInt("Teeth", teeth);
        PlayerPrefs.Save();
        UpdateTeethUI();
    }

    private void UpdateTeethUI()
    {
        teethCount.text = teeth.ToString();
    }
}
