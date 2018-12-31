using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Rewired;

public class InputHandler : MonoBehaviour
{
    public int playerId = 0;
    private Player player;

    private void Awake()
    {
        player = ReInput.players.GetPlayer(playerId);
    }
}
