using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{
	public UDPReceive udpReceive;
	public GameObject[] handPoints;
	// Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		string data = udpReceive.data;
		data = data.Remove(0, 1);
		data = data.Remove(data.Length-1, 1);
		print(data);
		string[] points = data.Split(',');
		print(points[0]);

		for (int i =0; i<=32;i++)
		{
			float x = float.Parse(points[0 + (i * 3)]) / 100;
			float y = float.Parse(points[1 + (i * 3)]) / 100;
			float z = float.Parse(points[2 + (i * 3)]) / 300;
			handPoints[i].transform.localPosition = new Vector3(x, y, z);
		}

}
}