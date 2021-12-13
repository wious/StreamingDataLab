using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySharingManager : MonoBehaviour
{

    public GameObject joinSharingRoomButton, sharingRoomNameInputField, sharePartyButton/*,sharingRoomNameText*/;

    public NetworkedClient networkClient;
    void Start()
    {
        joinSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButtonPressed);
        sharePartyButton.GetComponent<Button>().onClick.AddListener(SharePartyButtonPressed);

        networkClient = GetComponent<NetworkedClient>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void JoinSharingRoomButtonPressed()
    {
        string name = sharingRoomNameInputField.GetComponent<InputField>().text;
        networkClient.SendMessageToHost(ClientToServerSignifiers.JoinSharingRoom + "," + name );
    }

    private void SharePartyButtonPressed()
    {
        AssignmentPart2.SendPartyDataToSever(networkClient);

    }
}
