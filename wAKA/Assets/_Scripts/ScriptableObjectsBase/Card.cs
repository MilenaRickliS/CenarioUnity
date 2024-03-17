using System;
using System.Text;
using UnityEngine;

[CreateAssetMenu(fileName = "CardObject", menuName = "Card", order = 0)]
public class Card : ScriptableObject
{
    public string Name;
    public UInt16 Attack;
    public UInt16 Health;
    public UInt16 Level;
    public Sprite Image;

    public void PrintInfo()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Card Name: {this.Name}")
            .AppendLine($"Card Attack: {this.Attack}")
            .AppendLine($"Card Defense: {this.Health}")
            .AppendLine($"Card Level: {this.Level}");
        Debug.Log(sb.ToString());
    }
}
