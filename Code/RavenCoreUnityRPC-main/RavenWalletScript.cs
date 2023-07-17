using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;

public class RavenWalletScript : MonoBehaviour
{
    private string rpcUsername = "Your_UserName";
    private string rpcPassword = "Change_This_Password";
    private string rpcIP = "127.0.0.1";
    private string rpcPort = "8766";
    public float balance;
    public Text balanceText;

    void Start()
    {
        StartCoroutine(CallTheRpc());
    }

    IEnumerator CallTheRpc()
    {
        string url = $"http://{rpcUsername}:{rpcPassword}@{rpcIP}:{rpcPort}";
        string method = "getbalance";
        string requestData = "{\"jsonrpc\": \"1.0\", \"id\": \"curltest\", \"method\": \"" + method + "\", \"params\": [\"*\", 2]}";

        byte[] requestBytes = System.Text.Encoding.UTF8.GetBytes(requestData);

        using (UnityWebRequest webRequest = new UnityWebRequest(url, "POST"))
        {
            webRequest.uploadHandler = new UploadHandlerRaw(requestBytes);
            webRequest.downloadHandler = new DownloadHandlerBuffer();
            webRequest.SetRequestHeader("Content-Type", "text/plain");

            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.ConnectionError ||
                webRequest.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(webRequest.error);
            }
            else
            {
                string response = webRequest.downloadHandler.text;
                Debug.Log("Balance response: " + response);

                // Parse the response JSON to extract the balance value
                BalanceResponse balanceResponse = JsonUtility.FromJson<BalanceResponse>(response);
                balance = balanceResponse.result;

                // Update the balance text component
                balanceText.text = "Balance: " + balance.ToString();
            }
        }
    }

    // Class to hold the JSON response structure
    [System.Serializable]
    public class BalanceResponse
    {
        public float result;
        public string error;
        public string id;
    }
}