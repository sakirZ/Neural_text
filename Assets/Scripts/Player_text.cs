using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;
using TMPro;

public class Player_text : MonoBehaviour
{
    int player_Text = 0;
    [SerializeField]
    TextMeshProUGUI Player;
    [SerializeField]
    List<string> charactors = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Player.text = charactors[player_Text];
    }

    #region ¹öÆ°

    public void Up_Button()
    {
        player_Text += 1;
        if (player_Text >= charactors.Count)
        {
            player_Text = 0;
        }
    }

    public void Down_Button()
    {
        player_Text -= 1;
        if (player_Text < 0)
        {
            player_Text = charactors.Count-1;
        }
    }

    #endregion

}
