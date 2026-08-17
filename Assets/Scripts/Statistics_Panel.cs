using UnityEngine;

public class Statistics_Panel : MonoBehaviour
{
  [SerializeField] GameObject statPanel;
    

    
    void Update()
    {
       if(Input.GetKeyUp(KeyCode.Tab))
        {
            statPanel.SetActive(!statPanel.activeSelf);
        }
    }


}
