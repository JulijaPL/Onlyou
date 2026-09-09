using UnityEngine;
using UnityEngine.UI;
public class TabController : MonoBehaviour
{
    public Image[] tabImages;
    public GameObject[] pages;
    public Image Image;

    private  Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalColor = Image.color;
    }

    // Update is called once per frame
    void Update()
    {
        //ActivateTab(0);
    }
    public void ActivateTab ( int tabNo)
    {
       // Debug.Log("Klikniêto tab: " + tabNo);

        for (int i = 0; i < pages.Length; i++ )
        {
            pages[i].SetActive( false );
            tabImages[i].color = Color.gray3;
        }
        pages[tabNo].SetActive( true );
        tabImages[tabNo].color = originalColor;
    }
}
