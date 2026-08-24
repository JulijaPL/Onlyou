using UnityEngine;
using UnityEngine.UI;
public class StressBar : MonoBehaviour
{

    private Image Image;
    
    void Start()
    {
        Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradeStressBar(float maxStress, float currentStress)
    {
        Image.fillAmount = currentStress / maxStress;
    }
}
